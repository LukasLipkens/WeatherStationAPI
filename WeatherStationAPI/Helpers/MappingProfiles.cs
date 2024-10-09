using AutoMapper;
using WeatherStationAPI.Dto;
using WeatherStationAPI.Models;

namespace WeatherStationAPI.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Measurement, MeasurementDto>();
            CreateMap<Sensor, SensorDto>();
            CreateMap<Station, StationDto>();
            CreateMap<Station, SimpleStationDto>();
        }
    }
}
