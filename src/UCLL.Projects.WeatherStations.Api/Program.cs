#region

using Microsoft.EntityFrameworkCore;
using UCLL.Projects.WeatherStations.Api.Interfaces.Repositories;
using UCLL.Projects.WeatherStations.Api.Repositories;
using UCLL.Projects.WeatherStations.Shared.Data;

#endregion

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentVariables(prefix: "WEATHERSTATIONS_API_");

// add automapper for the Dto's
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add services to the container.
builder.Services.AddScoped<IStationRepository, StationRepository>();
builder.Services.AddScoped<IStationSensorRepository, StationSensorRepository>();
builder.Services.AddScoped<IMeasurementRepository, MeasurementRepository>();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter());
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

string databaseConnectionString = builder.Configuration.GetConnectionString("WeatherStationsDb")
    ?? throw new("ConnectionString 'WeatherStationsDb' not found.");

builder.Services.AddDbContext<WeatherstationsContext>(options =>
{
    options
        .UseLazyLoadingProxies()
        .UseSqlServer(databaseConnectionString)
        .EnableSensitiveDataLogging(false) // Don't log sensitive data
        .UseLoggerFactory(LoggerFactory.Create(loggingBuilder =>
        {
            loggingBuilder // log only warning level and above for EF SQL commands
                .AddFilter("Microsoft.EntityFrameworkCore.Database.Command", LogLevel.Warning);

            loggingBuilder // log debug and information levels for SQL commands to debug output
                .AddFilter("Microsoft.EntityFrameworkCore.Database.Command", LogLevel.Debug)
                .AddDebug();
        }));
});

WebApplication app = builder.Build();

// Apply any pending migrations automatically at startup
using (IServiceScope scope = app.Services.CreateScope())
{
    WeatherstationsContext context = scope.ServiceProvider.GetRequiredService<WeatherstationsContext>();
    await context.Database.MigrateAsync();
    await context.SeedDatabaseAsync();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// I like to always have the swagger documentation available
app.UseSwagger();
app.UseSwaggerUI();

//app.UseHttpsRedirection(); // prof's wishes

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
