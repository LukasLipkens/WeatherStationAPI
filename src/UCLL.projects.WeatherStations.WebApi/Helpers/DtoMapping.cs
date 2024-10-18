#region

using AutoMapper;
using UCLL.projects.WeatherStations.WebApi.Dto;
using UCLL.projects.WeatherStations.WebApi.Models;

#endregion

namespace UCLL.projects.WeatherStations.WebApi.Helpers
{
    public class DtoMapping : Profile
    {
        public DtoMapping() 
        { 
            CreateMap<Station, StationDto>();
            CreateMap<Measurement, MeasurementDto>();
            CreateMap<Sensor, SensorDto>();
        }
    }
}
