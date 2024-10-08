using Microsoft.EntityFrameworkCore;
using WeatherStationAPI.Interfaces;
using WeatherStationAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IWeatherStationsRepository, WeatherStationsRepository>();
builder.Services.AddScoped<IMeasurementsRepository, MeasurementsRepository>();
builder.Services.AddScoped<MqttService>();

builder.Services.AddDbContext<WeatherStationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WeatherStationDB")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
