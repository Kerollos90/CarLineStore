using AutoMapper;
using CarLine.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Service.Services.AppSellerServices.Dto
{
    public class UserProfile : Profile
    {

        public UserProfile() 
        {
            CreateMap<AppSeller, AppSellerDto>().ReverseMap();
        
        
        
        }
        
    }
}
