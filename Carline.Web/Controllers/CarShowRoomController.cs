using CarLine.Repository.Specification.CarShowRoomSpecifications;
using CarLine.Service.Services.CarShowRoomServices;
using CarLine.Service.Services.CarShowRoomServices.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carline.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarShowRoomController : ControllerBase
    {
        private readonly ICarShowRoomServices _services;

        public CarShowRoomController(ICarShowRoomServices services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<ListShowRoomDto>>> GetAllCarShowRoomAsync()
         => Ok(await _services.GetAllCarShowRoomAsync());


        [HttpGet]
        public async Task<ActionResult<ListShowRoomDto>> GetCarShowRoomById([FromQuery] int Id)
         => Ok(await _services.GetCarShowRoomByIdAsync(Id));


        [HttpPost]
        public async Task<ActionResult<CarShowRoomDto>> AddCarShowRoom([FromBody] CarShowRoomDto carShowRoomDto)
        {
            if (carShowRoomDto is null)
                throw new Exception("Error Your Data Not Completed");

            var result = await _services.AddCarShowRoomAsync(carShowRoomDto);


           return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ListShowRoomDto>> UpdateCarShowRoom([FromBody] ListShowRoomDto id)
        {
            if (id is null)
                throw new Exception("Error Your Data Not Completed");

            var result = await _services.UpdateCarShowRoomAsync(id);

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<bool>> DeleteCarShowRoom([FromQuery] int? Id)
        {
            if (Id is null)
                throw new Exception("Error Your Data Not Completed");

            var result = await _services.DeleteCarShowRoomAsync(Id);

            return Ok(result);
        }



    }
}
