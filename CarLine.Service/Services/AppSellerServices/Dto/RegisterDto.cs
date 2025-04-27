using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Service.Services.AppSellerServices.Dto
{
    public class RegisterDto
    {

        public string DisplayName { get; set; } =  $"Hello";
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "password is required")]
     
        public string Password { get; set; }





    }
}
