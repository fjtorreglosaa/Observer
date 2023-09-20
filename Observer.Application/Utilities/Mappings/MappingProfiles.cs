using AutoMapper;
using Observer.Application.Utilities.DTOs.Stock;
using Observer.Application.Utilities.DTOs.Warehouse;
using Observer.Application.Utilities.Helpers;
using Observer.Domain.Entities;
using Observer.Domain.Models;

namespace Observer.Application.Utilities.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Warehouse, WarehouseDto>().ReverseMap();

            CreateMap<Stock, ParcialStockCountDto>()
                .ForMember(dest => dest.ItemId, opt => opt.MapFrom(src => src.ItemId))
                .ForMember(dest => dest.StockId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.StockQuantity, opt => opt.MapFrom(src => src.Quantity))
                .ForMember(dest => dest.MinimumAllowedQuantity, opt => opt.MapFrom(src => src.MinimumStock))
                .ReverseMap();

            CreateMap<StockInPlace, StockInPlaceDto>()
                .ForMember(dest => dest.ItemId, opt => opt.MapFrom(src => src.ItemId))
                .ForMember(dest => dest.StockId, opt => opt.MapFrom(src => src.StockId))
                .ForMember(dest => dest.Identifier, opt => opt.MapFrom(src => src.Identifier))
                .ForMember(dest => dest.PositionId, opt => opt.MapFrom(src => src.PositionId))
                .ForMember(dest => dest.DaysFromLastDiscount, opt => opt.MapFrom(src => src.GetDaysFromLastDiscount()))
                .ReverseMap();
        }
    }
}
