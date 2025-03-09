using AutoMapper;
using CarLine.Model.Entity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Service.Services.CarServices.Dto
{
    public class CarProfile : Profile
    {
        public CarProfile()
        {





            CreateMap<Picture, PictureDto>()
                .ForMember(dest => dest.PictureUrl, opt => opt.MapFrom(src => src.PictureUrl)).ReverseMap();

                       CreateMap<Car, CarDetailsDto>()
                .ForMember(dest => dest.PictureUrl, opt => opt.MapFrom<CarPictureUrlResolver>())  
                .ForMember(dest => dest.AppSellerDtoId, opt => opt.MapFrom(src=>src.AppSellerId)).ReverseMap();

            CreateMap<Car, CarDto>()
            .ForMember(dest => dest.PictureUrl , opt => opt.MapFrom(x=>x.PictureUrl.Select(x=>x.PictureUrl).ToString())).ReverseMap();

            
            CreateMap<Car, CarDto>().ReverseMap();
            CreateMap<Car, CarPriceDto>().ReverseMap();
            CreateMap<Car, Picture>().ReverseMap();
            CreateMap<CarDto, PictureDto>().ReverseMap();      
            
            CreateMap<Car, Equipment>().ReverseMap();
            CreateMap<CarDto, EquipmentDto>().ReverseMap();
            CreateMap<Equipment, EquipmentDto>().ReverseMap();
            CreateMap<Phone, PhoneDto>().ReverseMap();
            CreateMap<AppSeller, AppSellerDto>().ReverseMap();
            CreateMap<AppSeller, Phone>().ReverseMap();
            CreateMap<AppSellerDto, PhoneDto>().ReverseMap();
            CreateMap<AppSeller, Car>()
                .ForMember(dest=>dest.AppSellerId , opt=>opt.MapFrom(src=>src.Id)).ReverseMap();
            
            CreateMap<AppSeller, AppSellerDto>()
                .ForMember(dest=>dest.Id ,opt=>opt.MapFrom(src=>src.Id)).ReverseMap();

            CreateMap<AppSellerDto, CarDetailsDto>()
                .ForMember(dest=>dest.AppSellerDtoId, opt=>opt.MapFrom(src=>src.Id)).ReverseMap();

            

         








        }
            
        
        
        }


    }



