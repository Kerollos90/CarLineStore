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

        public async Task<CarDto> AddCar(CarDto car)
        {
            
           var cars =  _mapper.Map<Car>( car );

             await _unitOfWork.Repository<Car, int>().AddAsync(cars);
            _unitOfWork.CompleteAsync();

            var result = _mapper.Map<CarDto>(cars);

            return result;


            
        }

        public async Task<CarDetailsDto> CarDetailsAsync(int? spec)
        {
            var specif = new CarSpecification(spec);

            var cars = await _unitOfWork.Repository<Car, int>().GetWithSpcificationById(specif);


            








            var Mapped = _mapper.Map<CarDetailsDto>(cars);

            return Mapped;
        }

        

        public async Task<IReadOnlyList<CarDto>> GetAllCarAsync(BaseCarSpecification spec)
        {
            

            
            var specif = new CarSpecification( spec );

            var cars= await _unitOfWork.Repository<Car,int >().GetAllWithSpcificationAsync(specif);



            var carsMapped = _mapper.Map<IReadOnlyList<CarDto>>( cars );
            return carsMapped;


        }



        
    }
}
