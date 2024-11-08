#region

using Microsoft.EntityFrameworkCore;
using UCLL.Projects.WeatherStations.Shared.Data;
using UCLL.Projects.WeatherStations.WebApi.Interfaces;
using UCLL.Projects.WeatherStations.WebApi.Repositories;

#endregion

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// add automapper for the Dto's
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add services to the container.
builder.Services.AddScoped<IMeasurementRepository, MeasurementRepository>();
builder.Services.AddScoped<IStationRepository, StationRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options => { options.UseSqlServer(builder.Configuration.GetConnectionString("WeatherStationDb")); });

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// I like to always have the swagger documentation available
app.UseSwagger();
app.UseSwaggerUI();

//app.UseHttpsRedirection(); // prof's wishes

app.UseAuthorization();

app.MapControllers();

app.Run();