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
    public class CarPictureUrlResolver : IValueResolver<Car, CarDetailsDto, List<PictureDto>>
    {
        private readonly IConfiguration _configuration;

        public CarPictureUrlResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        public List<PictureDto> Resolve(Car source, CarDetailsDto destination, List<PictureDto> destMember, ResolutionContext context)
        {
            if (source.PictureUrl == null || !source.PictureUrl.Any())
                return new List<PictureDto>();

            return source.PictureUrl.Select(p => new PictureDto
            {
                Id = p.Id,
                PictureUrl = $"{_configuration["BaseUrl"]}/{p.PictureUrl}",
                CarDtoId = p.CarId
            }).ToList(); 
        }
    }
}
