using UCLL.Projects.WeatherStations.GraphQL.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>() //voegt file toe aan server
    .AddType<Playlist>();

//cors policy voor sandbox
builder
    .Services
    .AddCors(options =>
    {
        options.AddDefaultPolicy(builder =>
        {
            builder
            .WithOrigins("https://studio.apollographql.com")
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
    });

var app = builder.Build();

app.UseCors();

//This function adds a GraphQL endpoint to the endpoint configurations, which means our GraphQL server will be available at /graphql.
app.MapGraphQL();

app.Run();