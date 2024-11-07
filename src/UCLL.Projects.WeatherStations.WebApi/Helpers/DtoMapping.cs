#region

using AutoMapper;
using UCLL.Projects.WeatherStations.Shared.Models;
using UCLL.Projects.WeatherStations.WebApi.Dto;

#endregion

namespace UCLL.Projects.WeatherStations.WebApi.Helpers;

public class DtoMapping : Profile
{
    public DtoMapping()
    {
        CreateMap<Station, StationDto>();
        CreateMap<Measurement, MeasurementDto>();
        CreateMap<Sensor, SensorDto>();
        CreateMap<Station, SimpleStationDto>();
    }
}