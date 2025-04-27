using AutoMapper;
using CarLine.Model.Entity;
using CarLine.Service.Services.AppSellerServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Service.Services.CarShowRoomServices.Dto
{
    public class ShowRoomProfile : Profile
    {
        public ShowRoomProfile()
        {
            CreateMap<CarShowRoom, CarShowRoomDto>()
                .ForMember(dest => dest.AppSellerDtoId, opt => opt.MapFrom(ser => ser.AppSellerId)).ReverseMap();
            CreateMap<CarShowRoom, ListShowRoomDto>()
                .ForMember(dest =>dest.AppSellerDtoId , opt=> opt.MapFrom(ser =>ser.AppSellerId))
                .ReverseMap();

            CreateMap<Address, AddressDto>().ReverseMap();

            CreateMap<AppSeller,AppSellerDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ReverseMap();





        }
    }
}
