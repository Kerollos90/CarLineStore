﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Service.Services.CarServices.Dto
{
    public class PictureDto
    {
        internal int Id { get; set; }
        public string PictureUrl { get; set; }

        internal int? CarDtoId { get; set; }

    }
}
