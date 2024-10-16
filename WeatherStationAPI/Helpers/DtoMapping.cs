using AutoMapper;
using WeatherStationAPI.Dto;
using WeatherStationAPI.Models;

namespace WeatherStationAPI.Helpers
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
