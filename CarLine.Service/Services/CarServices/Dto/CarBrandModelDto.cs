namespace CarLine.Service.Services.CarServices.Dto
{
    public class CarBrandModelDto : CarPriceDto
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public List<CarPriceDto> YearPrices { get; set; } = new List<CarPriceDto>();
    }
}