using CarLine.Repository.Specification.CarShowRoomSpecifications;
using CarLine.Service.Services.CarShowRoomServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Service.Services.CarShowRoomServices
{
    public interface ICarShowRoomServices
    {

        Task<IReadOnlyList<ListShowRoomDto>> GetAllCarShowRoomAsync();
        Task<ListShowRoomDto> GetCarShowRoomByIdAsync(int Id);
        Task<CarShowRoomDto> AddCarShowRoomAsync(CarShowRoomDto carShowRoomDto);
        Task<ListShowRoomDto> UpdateCarShowRoomAsync(ListShowRoomDto carShowRoomDto);
        Task<bool> DeleteCarShowRoomAsync(int? Id);



    }
}
