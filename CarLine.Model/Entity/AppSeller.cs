using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Model.Entity
{
    public class AppSeller : IdentityUser
    {
        [Key]
        public Guid Id { get; set; }

        public string DisplayName { get; set; }

        public List<Phone> Phone { get; set; }
        [NotMapped]
        public int PhoneId { get; set; }

        public List<Car> Car { get; set; }
        [NotMapped]
        public int CarId { get; set; }

    }
}
