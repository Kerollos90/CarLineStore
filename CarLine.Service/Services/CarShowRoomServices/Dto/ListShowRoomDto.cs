using CarLine.Service.Services.CarServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Service.Services.CarShowRoomServices.Dto
{
    public class ListShowRoomDto
    {
        public int Id { get; set; }
        public string DealerName { get; set; }

        public string? Email { get; set; } 
        public List<AddressDto> Address { get; set; } = new List<AddressDto>();

        public List<PhoneDto> Phone { get; set; } = new List<PhoneDto>();

        public string? Website { get; set; }
        public DealerTypeDto DealerType { get; set; }
        public PictureDto? PictureUrl { get; set; }

        public string? AppSellerDtoId { get; set; }

        //  public List<CarDetailsDto> Car { get; set; } = new List<CarDetailsDto>();


    }
}
