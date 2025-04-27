using AutoMapper;
using CarLine.Model.Entity;
using CarLine.Repository.Interfices;
using CarLine.Service.Services.CarShowRoomServices.Dto;
using CarLine.Service.Services.CarShowRoomServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLine.Model.Entity;
using CarLine.Repository.Specification.CarShowRoomSpecifications;
using CarLine.Service.Services.CarServices.Dto;

namespace CarLine.Service.Services.CarShowRoomServices
{
    public class CarShowRoomService : ICarShowRoomServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CarShowRoomService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CarShowRoomDto> AddCarShowRoomAsync(CarShowRoomDto carShowRoomDto)
        {
            if (carShowRoomDto == null)
            {
                throw new ArgumentNullException(nameof(carShowRoomDto));
            }

            var Car = _mapper.Map<CarShowRoom>(carShowRoomDto);

            await _unitOfWork.Repository<CarShowRoom, int>().AddAsync(Car);

            await _unitOfWork.CompleteAsync();

            var result = _mapper.Map<CarShowRoomDto>(Car);

            return result;

        }

        public async Task<bool> DeleteCarShowRoomAsync(int? Id)
        {
            if (Id == null)
            {
                throw new ArgumentNullException(nameof(Id));
            }

            var carShowRoom = await _unitOfWork.Repository<CarShowRoom, int>().GetById(Id);

            if (carShowRoom == null)
            {
                throw new ArgumentNullException(nameof(carShowRoom));
            }

            _unitOfWork.Repository<CarShowRoom, int>().Delete(carShowRoom);
            await _unitOfWork.CompleteAsync();

            return true;



        }

        public async Task<IReadOnlyList<ListShowRoomDto>> GetAllCarShowRoomAsync()
        {
            var spec = new CarShowRoomSpecification();

            var carShowRoom = await _unitOfWork.Repository<CarShowRoom, int>().GetAllWithSpcificationAsync(spec);

            if (carShowRoom == null)
            {
                throw new ArgumentNullException(nameof(carShowRoom));
            }

            var carShowRoomDto = _mapper.Map<IReadOnlyList<ListShowRoomDto>>(carShowRoom);

            return carShowRoomDto;
        }

        public async Task<ListShowRoomDto> GetCarShowRoomByIdAsync(int Id)
        {
            if (Id == null)
            {
                throw new ArgumentNullException(nameof(Id));
            }

            var spec = new CarShowRoomSpecification(Id);

            var carShowRoom = await _unitOfWork.Repository<CarShowRoom, int>().GetWithSpcificationById(spec);

            var carShowRoomDto = _mapper.Map<ListShowRoomDto>(carShowRoom);

            return carShowRoomDto;

        }

        public async Task<ListShowRoomDto> UpdateCarShowRoomAsync(ListShowRoomDto carShowRoomDto)
        {



            var ss = await _unitOfWork.Repository<CarShowRoom, int>().GetByIdAsNotTracked(carShowRoomDto.Id);

            var vv = new CarShowRoom
            {
                Id = carShowRoomDto.Id,
                DealerName = carShowRoomDto.DealerName ?? ss.DealerName,
                Email = carShowRoomDto.Email ?? ss.Email,
                Website = carShowRoomDto.Website ?? ss.Website,

                Phone = carShowRoomDto.Phone != null && carShowRoomDto.Phone.Any() ?
              carShowRoomDto.Phone.Select(x => new Phone
              {
                  Id = x.Id,
                  PhoneNumber = x.PhoneNumber
              }).ToList() : ss.Phone,


                Address = carShowRoomDto.Address != null && carShowRoomDto.Address.Any() ?
                carShowRoomDto.Address.Select(x => new Address
                {
                    Id = x.Id,
                    City = x.City,
                    State = x.State,
                    Street = x.Street
                }).ToList() : ss.Address,
                PictureUrl = carShowRoomDto.PictureUrl != null ? new Picture
                {
                    Id = carShowRoomDto.PictureUrl.Id,
                    PictureUrl = carShowRoomDto.PictureUrl.PictureUrl,
                    CarId = carShowRoomDto.PictureUrl.CarDtoId,
                } : ss.PictureUrl,

                DealerType = carShowRoomDto.DealerType != null ? (DealerType)carShowRoomDto.DealerType : ss.DealerType,
                AppSellerId =  ss.AppSellerId,




            };












            if (vv == null)
            {
                throw new ArgumentNullException(nameof(vv));
             }



                    _unitOfWork.Repository<CarShowRoom, int>().Update(vv);
                    await _unitOfWork.CompleteAsync();

                   var car = _mapper.Map<ListShowRoomDto>(vv);



                  return car;
        
        }

        
    }

}
