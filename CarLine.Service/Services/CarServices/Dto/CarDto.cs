using CarLine.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CarLine.Service.Services.CarServices.Dto
{
    public class CarDto
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }


        public string Color { get; set; }

        public short Year { get; set; }
        public decimal Price { get; set; }

        public string CarAddress { get; set; }


        public CarStatus CarStatus { get; set; }
       



    }

     public enum CarStatus
    {
        New = 1,
        Used = 2,
        Imported

    }

    public enum Transmission
    {
        Manual = 1,
        Automatic = 2


    }

    public enum FuelType
    {
        Gas = 1,
        Diesel,
        naturalGas,
        Electric,
        Hybird


    }

    public enum CarPaymentStatus
    {
        Pending = 1,
        Recived,
        Failed

    }


   

    
}
