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
       

        public string DisplayName { get; set; }

       
        

        public List<Car> Car { get; set; } = new List<Car> { };
        

    }
}
