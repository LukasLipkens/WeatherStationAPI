namespace UCLL.Projects.WeatherStations.Shared.Data.Models;

public class Station_Sensor
{
    public string StationId { get; set; }

    public int SensorId { get; set; }

    //relationships
    public Station Station { get; set; } = null!;
    public Sensor Sensor { get; set; } = null!;
}