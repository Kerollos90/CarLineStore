using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Model.Entity
{
    
    public class MaintenanceCenter
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public Address  Address { get; set; }

        public Picture? PictureUrl { get; set; } 

        public List<CarBrand> CarSpecialzedBrand { get; set; } = new List<CarBrand>

        public List<Phone> Phone { get; set; } = new List<Phone>();

        public AppSeller  AppSeller { get; set; }




    }
}
