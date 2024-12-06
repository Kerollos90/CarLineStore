using CarLine.Model.Entity;
using CarLine.Repository.Specification.CarSpecifications;
using CarLine.Service.Services.CarServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Service.Services.CarServices
{
    public interface ICarService
    {
        Task<IReadOnlyList<CarDto>> GetAllCarAsync(BaseCarSpecification spec);

        Task<CarDetailsDto> CarDetailsAsync(int? spec);

        Task<CarDto> AddCar(CarDto car);
    }
}
