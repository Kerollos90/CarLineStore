using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Model.Entity
{

    public enum DealerType
    { 
        NewCar = 1,
        UsedCar = 2,
        Importedcars = 3,
        ALl = 4

    
    
    }

    public class CarShowRoom : BaseEntity<int>
    {
        

        public string DealerName { get; set; }
        
        public string Email { get; set; }

        public List<Address> Address { get; set; } = new List<Address> ();
        [NotMapped]

        public int AddressId { get; set; }



        public List<Phone> Phone { get; set; } = new List<Phone>(); 
        [NotMapped]

        public int PhoneId { get; set; }

        public string Website { get; set; }
        public DealerType DealerType { get; set; }

        public List<Car> Car { get; set; } = new List<Car>();
        [NotMapped]
        public int CarId { get; set; }


        public string? AppSellerId { get; set; }

        public Picture? PictureUrl { get; set; } 

    }
}
