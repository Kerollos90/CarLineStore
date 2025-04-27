using CarLine.Model.Entity;
using CarLine.Service.Services.AppSellerServices.Dto;
using CarLine.Service.Services.CarServices.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Service.Services.CarShowRoomServices.Dto
{


    public enum DealerTypeDto
    {
        NewCar = 1,
        UsedCar = 2,
        Importedcars = 3,
        ALl = 4



    }


    public class CarShowRoomDto
    {

        internal int Id { get; set; }
        public string DealerName { get; set; }

        public string Email { get; set; }

        public List<AddressDto> Address { get; set; } = new List<AddressDto>();
      



        public List<PhoneDto> Phone { get; set; } = new List<PhoneDto>();
   

        public string Website { get; set; }
        public DealerTypeDto DealerType { get; set; }

        public List<CarDetailsDto> Car { get; set; } = new List<CarDetailsDto>();


        

        public string? AppSellerDtoId { get; set; }

        public PictureDto? PictureUrl { get; set; }


    }
}
