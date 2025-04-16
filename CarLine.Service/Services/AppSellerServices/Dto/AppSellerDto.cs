using CarLine.Model.Entity;
using CarLine.Service.Services.CarServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Service.Services.AppSellerServices.Dto
{
    public class AppSellerDto
    {

        public string Id { get; set; }

        public string DisplayName { get; set; }

        public string Email { get; set; }



        public List<CarDetailsDto> Car { get; set; } = new List<CarDetailsDto>();
    }
}
