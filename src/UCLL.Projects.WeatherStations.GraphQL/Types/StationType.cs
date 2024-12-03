using HotChocolate.Types;
using UCLL.Projects.WeatherStations.Shared.Data.Models;

public class StationType : ObjectType<Station>
{
    protected override void Configure(IObjectTypeDescriptor<Station> descriptor)
    {
        // Configureer het stationSensors-veld
        descriptor.Field(s => s.StationSensors)
            .UseFiltering() // Filtering op stationSensors inschakelen
            .UseSorting()   // Sorting op stationSensors inschakelen
            .UseProjection(); // Voor nested data
    }
}
