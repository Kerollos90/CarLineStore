using AutoMapper;
using CarLine.Model.Context;
using CarLine.Model.Entity;
using CarLine.Repository.Interfices;
using CarLine.Repository.Repostories;
using CarLine.Repository.Specification.CarSpecifications;
using CarLine.Service.Services.CarServices.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Service.Services.CarServices
{
    public class CarService : ICarService
    {
        private readonly IUnitOfWork _unitOfWork;
        
        private readonly IMapper _mapper;

        public CarService( IUnitOfWork unitOfWork , IMapper mapper ) 
        {
            _unitOfWork = unitOfWork;
            
            _mapper = mapper;
        }

        public async Task<CarDetailsDto> AddCar(CarDetailsDto car)
        {

            if (car is null)
                throw new Exception("Error Your Data Not Completed");

           

           var cars =  _mapper.Map<Car>( car );

            
            
            
              await _unitOfWork.Repository<Car, int>().AddAsync(cars);
             await _unitOfWork.CompleteAsync();


            var result = _mapper.Map<CarDetailsDto>( cars );
            if (result is null)
                throw new Exception("Error Your Data Not Completed");
            return result;


            

            

           


            
        }

        public async Task<CarBrandModelDto> AvgCarByYearAsync(string brand, string model)
        {

            if(string.IsNullOrEmpty(brand)||string.IsNullOrEmpty(model))
            throw new Exception("Error Your Data Not Completed");


            var spec = new CarSpecification(brand, model);


            var cars = await _unitOfWork.Repository<Car, int>().GetAllWithSpcificationAsync(spec);

            

            if (!cars.Any())
            throw new Exception("Barnd Or Model Not Found");
               


            var yearPrices = cars.GroupBy(car => car.Year)
                                 .Select(x => new CarPriceDto
                                 {
                                     Year = x.Key,
                                     MinPrice = ((int)x.Min(c => c.Price)),
                                     MaxPrice = ((int)x.Max(c => c.Price)),
                                     AveragePrice = ((int)x.Average(c => c.Price))
                                 })
                                 .OrderBy(y => y.Year) 
                                 .ToList();

           
            return new CarBrandModelDto
            {
                Brand = brand,
                Model = model,
                YearPrices = yearPrices
            };

        }

        public async Task<CarDetailsDto> CarDetailsAsync(int? spec)
        {


            var specif = new CarSpecification(spec);

            var cars = await _unitOfWork.Repository<Car, int>().GetWithSpcificationById(specif);

            if(cars is null)
                throw new Exception("Car Not Found");



            var Mapped = _mapper.Map<CarDetailsDto>(cars);

            return Mapped;
        }

        

        public async Task<List<CarDto>> GetAllCarAsync(BaseCarSpecification spec)
        {
            

            
            var specif = new CarSpecification( spec );

            var cars= await _unitOfWork.Repository<Car,int >().GetAllWithSpcificationAsync(specif);



        

           // var carsMapped = _mapper.Map<List<CarDetailsDto>>(cars);
            var carsMappe = _mapper.Map<List<CarDto>>(cars);


           



            return carsMappe;






        }



        
    }
}
