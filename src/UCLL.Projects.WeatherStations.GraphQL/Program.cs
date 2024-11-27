using UCLL.Projects.WeatherStations.GraphQL.Types;
using UCLL.Projects.WeatherStations.Shared.Data;

var builder = WebApplication.CreateBuilder(args);

// Voeg de DbContext toe via de extensie
builder.Services.AddWeatherstationsData(builder.Configuration);

// Voeg GraphQL toe
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();

var app = builder.Build();

app.MapGraphQL();

app.Run();
