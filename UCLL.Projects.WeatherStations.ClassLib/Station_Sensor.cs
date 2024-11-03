namespace UCLL.Projects.WeatherStations.ClassLib;

public class Station_Sensor
{
    public int StationId { get; set; }

    public int SensorId { get; set; }

    //relationships
    public Station Station { get; set; } = null!;
    public Sensor Sensor { get; set; } = null!;
}