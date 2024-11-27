using Microsoft.EntityFrameworkCore;
using UCLL.Projects.WeatherStations.GraphQL.QueryTypes;
using UCLL.Projects.WeatherStations.Shared.Data;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentVariables(prefix: "WEATHERSTATIONS_GRAPHQL_");

// Add services to the container
builder.Services.AddDbContext<WeatherstationsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WeatherStationsDb")));

// Add GraphQL server
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()    // Je Query klasse
    .AddProjections()         // Voor nested objecten
    .AddFiltering()           // Voor filter queries
    .AddSorting();            // Voor sorteer mogelijkheden

WebApplication app = builder.Build();

app.MapGraphQL("/graphql");

app.Run();