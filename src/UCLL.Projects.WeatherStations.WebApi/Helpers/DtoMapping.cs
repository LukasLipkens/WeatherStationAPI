#region

using AutoMapper;
using UCLL.Projects.WeatherStations.WebApi.Dto;
using UCLL.Projects.WeatherStations.WebApi.Models;

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