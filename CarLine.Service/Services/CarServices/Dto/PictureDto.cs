using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Service.Services.CarServices.Dto
{
    public class PictureDto
    {
        public int Id { get; set; }
        public string PictureUrl { get; set; }

        public int? CarDtoId { get; set; }

    }
}
