namespace UCLL.Projects.WeatherStations.Shared.Data.Models;

public class StationSensor
{
    public int Id { get; set; }
    public required string StationId { get; set; }
    public required int SensorId { get; set; }

    //navigation properties
    public virtual Station Station { get; set; } = null!;
    public virtual Sensor Sensor { get; set; } = null!;
    public virtual ICollection<Measurement> Measurements { get; set; } = null!;
}