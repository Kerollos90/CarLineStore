using CarLine.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Service.Services.CarServices.Dto
{
    public class AppSellerDto
    {

        public int Id { get; set; }

        public string DisplayName { get; set; }

        public List<Phone> Phone { get; set; } = new List<Phone>();


        public List<CarDto> Car { get; set; } = new List<CarDto> ();
    }
}
