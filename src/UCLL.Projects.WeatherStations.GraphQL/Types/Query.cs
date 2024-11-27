using System.Linq;
using HotChocolate;
using HotChocolate.Data;
using UCLL.Projects.WeatherStations.Shared.Data;
using UCLL.Projects.WeatherStations.Shared.Data.Models;

public class Query
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Station> GetStations([Service] WeatherstationsContext dbContext)
    {
        return dbContext.Stations;
    }

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Sensor> GetSensors([Service] WeatherstationsContext dbContext)
    {
        return dbContext.Sensors;
    }

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Measurement> GetMeasurements([Service] WeatherstationsContext dbContext)
    {
        return dbContext.Measurements;
    }
}
