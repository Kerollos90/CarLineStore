using CarLine.Repository.Specification.CarSpecifications;
using CarLine.Service.Services.CarServices;
using CarLine.Service.Services.CarServices.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carline.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<CarDto>>> GetAllCarsAsync([FromQuery]BaseCarSpecification specif)
         => Ok(await _carService.GetAllCarAsync(specif));


        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<CarDetailsDto>>>  GetCarDetailsById([FromQuery] int? Id)
         => Ok(await _carService.CarDetailsAsync(Id));
        
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<CarBrandModelDto>>>  GetAVGCarByYear([FromQuery] string Brand, string Model)
         => Ok(await _carService.AvgCarByYearAsync(Brand,Model));

        [HttpPost]
        public async Task<ActionResult<CarDetailsDto>> AddCar([FromBody] CarDetailsDto carDto)
        {
           var result= await _carService.AddCar(carDto);
           
          return Ok( result);

        }
    }
}
