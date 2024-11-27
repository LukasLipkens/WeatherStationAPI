using Microsoft.EntityFrameworkCore;
using UCLL.Projects.WeatherStations.Shared.Data; // Namespace van je DbContext
using UCLL.Projects.WeatherStations.Shared.Data.Models;

var builder = WebApplication.CreateBuilder(args);

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

var app = builder.Build();

// Redirect root URL ("/") to "/graphql"
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/", context =>
    {
        context.Response.Redirect("/graphql");
        return Task.CompletedTask;
    });

    endpoints.MapGraphQL("/graphql"); // GraphQL endpoint
});

app.Run();
