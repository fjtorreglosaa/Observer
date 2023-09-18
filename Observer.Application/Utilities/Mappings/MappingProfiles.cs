using AutoMapper;
using Observer.Application.Utilities.DTOs.Warehouse;
using Observer.Domain.Entities;

namespace Observer.Application.Utilities.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Warehouse, WarehouseDto>().ReverseMap();
        }
    }
}
