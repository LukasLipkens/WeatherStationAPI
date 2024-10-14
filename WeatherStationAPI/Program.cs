using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using WeatherStationAPI.Data;
using WeatherStationAPI.Interfaces;
using WeatherStationAPI.Repositories;
using WeatherStationAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// add automapper for the Dto's
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add services to the container.
builder.Services.AddScoped<IMeasurementRepository, MeasurementRepository>();
builder.Services.AddScoped<IStationRepository, StationRepository>();

builder.Services.AddControllers();
builder.Services.AddHostedService<BackgroundWorkerService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("WeatherStationDb"));
});

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
