using CarLine.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Repository.Specification.CarSpecifications
{
    public class BaseCarSpecification
    {

        private int? Id { get; set; }


        private string? _City;


        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        private string? _Color;
        public string? Color
        {
            get => _Color; 
            set => _Color = value?.Trim().ToLower(); 
        }


        public string? City
        {
            get => _City;
            set => _City = value?.Trim().ToLower();
        }


        private string? _Model;

        public string? Model
        {
            get => _Model;
            set => _Model = value?.Trim().ToLower();
        }

        private string? _Brand { get; set; }
        
        public string? Brand
        {
            get => _Brand;
            set => _Brand = value?.Trim().ToLower();
        }



        public string? CarStatus { get; set; }

        internal CarStatus? _CarStatus
        {
            get
            {
                return Enum.TryParse<CarStatus>(CarStatus, true, out var statusEnum) ? statusEnum : (CarStatus?)null ;
            }
            set
            {
                CarStatus = value?.ToString();
            }
        }


        public short? MinYear { get; set; }
        public short? MaxYear { get; set; }






    }
}
