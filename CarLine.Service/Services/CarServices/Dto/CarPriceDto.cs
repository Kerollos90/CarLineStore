namespace CarLine.Service.Services.CarServices.Dto
{
    public class CarPriceDto 
    {

       
        public short Year { get; set; }
        public decimal AveragePrice { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
    }
}