using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Service.Services.CarServices.Dto
{
    public class CarDetailsDto : CarDto
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }


        public string Color { get; set; }

        public short Year { get; set; }
        public decimal Price { get; set; }

        public string CarAddress { get; set; }


        public CarStatus CarStatus { get; set; }

        public string Description { get; set; }

        public string EngineType { get; set; }

        public Transmission Transmission { get; set; }

        public FuelType FuelType { get; set; }

        public int Millage { get; set; }


        public DateTime DateTime { get; set; } = DateTime.Now.Date;

        public List<PictureDto>? PictureUrl { get; set; } = new List<PictureDto>();


        public ICollection<EquipmentDto>? Equipments { get; set; } = new List<EquipmentDto>();

        public bool Taxi { get; set; }

        public bool Financed { get; set; }

        public decimal? MinimumDeposit { get; set; }
        public decimal? MinimumInstallment { get; set; }

        public string MobilePhone { get; set; }

        public string Whatsapp { get; set; }

        public string DisplayName { get; set; }

        private CarPaymentStatus carPayment { get; set; }
    }
}
