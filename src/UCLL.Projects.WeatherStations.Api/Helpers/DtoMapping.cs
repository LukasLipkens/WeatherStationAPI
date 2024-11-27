#region

using AutoMapper;
using UCLL.Projects.WeatherStations.Api.Dto;
using UCLL.Projects.WeatherStations.Shared.Data.Models;

#endregion

namespace UCLL.Projects.WeatherStations.Api.Helpers;

public class DtoMapping : Profile
{
    public DtoMapping()
    {
        CreateMap<Station, StationDto>();
        CreateMap<Measurement, MeasurementDto>();
        CreateMap<Sensor, SensorDto>();
        CreateMap<Station, SimpleStationDto>();
        CreateMap<Station, UpdateStationDto>();
    }
}