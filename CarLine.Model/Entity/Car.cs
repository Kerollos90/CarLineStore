using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Model.Entity
{

    public enum CarStatus
    { 
        New = 1,
        Used = 2,
        Imported 

    }

    public enum Transmission
    { 
        Manual = 1,
        Automatic= 2

    
    }

    public enum FuelType
    { 
        Gas= 1,
        Diesel,
        naturalGas,
        Electric,
        Hybird
    
    
    }

    public enum CarPaymentStatus
    {
        Pending =1,
        Recived,
        Failed

    }

    public class Car : BaseEntity<int>
    {



        public string Brand { get; set; }


        public string Color { get; set; }
        public string Description { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public short Year { get; set; }

        public CarStatus CarStatus { get; set; }

        public string EngineType { get; set; }

        public Transmission Transmission { get; set; }

        public FuelType FuelType { get; set; }

        public int Millage { get; set; }

        public string CarAddress { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now.Date;

        public ICollection<Picture>? PictureUrl { get; set; } = new List<Picture>();
        

        public ICollection<Equipment>? Equipments { get; set; } = new List<Equipment>();

        public bool Taxi { get; set; }

        public bool Financed { get; set; }

        public decimal? MinimumDeposit { get; set; }
        public decimal? MinimumInstallment { get; set; }

        public string MobilePhone { get; set; }

        public string Whatsapp { get; set; }

        public CarPaymentStatus carPayment { get; set; } = CarPaymentStatus.Pending;

        public bool IsDeleted { get; set; } = false;
       
        public string? AppSellerId { get; set; }


    }
}
