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
                .ForMember(dest => dest.PictureUrl, opt => opt.MapFrom(src => src.PictureUrl));

                       CreateMap<Car, CarDetailsDto>()
                .ForMember(dest => dest.PictureUrl, opt => opt.MapFrom<CarPictureUrlResolver>());

            CreateMap<Car, CarDto>().ReverseMap();
            CreateMap<Car, Picture>().ReverseMap();
            CreateMap<CarDto, PictureDto>().ReverseMap();      
            
            CreateMap<Car, Equipment>().ReverseMap();
            CreateMap<CarDto, EquipmentDto>().ReverseMap();
            CreateMap<Equipment, EquipmentDto>().ReverseMap();


            

         








        }
            
        
        
        }


    }



