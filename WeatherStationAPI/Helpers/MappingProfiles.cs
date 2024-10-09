using AutoMapper;

namespace WeatherStationAPI.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Models.Measurement, Dto.MeasurementDto>();
            CreateMap<Models.Sensor, Dto.SensorDto>();
            CreateMap<Models.Station, Dto.StationDto>();
        }
    }
}
