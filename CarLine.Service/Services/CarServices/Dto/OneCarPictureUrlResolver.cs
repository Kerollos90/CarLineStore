using AutoMapper;
using CarLine.Model.Entity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Service.Services.CarServices.Dto
{
    public class OneCarPictureUrlResolver :  IValueResolver<Car, CarDto, List<PictureDto>>
    {
        private readonly IConfiguration _configuration;

        public OneCarPictureUrlResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<PictureDto> Resolve(Car source, CarDto destination, List<PictureDto> destMember, ResolutionContext context)
        {

            if (source.PictureUrl == null || !source.PictureUrl.Any())
                return null;

            

            return source.PictureUrl.Select(x=> new PictureDto
            {
                Id = x.Id,
                PictureUrl = $"{_configuration["BaseUrl"]}/{x.PictureUrl}",
                CarDtoId = x.CarId
            }).ToList();
        }
    }
}