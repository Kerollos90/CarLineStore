using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Model.Entity
{
    public class Wanch
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Email { get; set; }

        public List<Phone> Phone { get; set; }
        [NotMapped]
        public int PhoneId { get; set; }

        public AppSeller AppSeller { get; set; }

        public List<Picture>? PictureUrl { get; set; } = new List<Picture>();







    }
}
