using CarLine.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Repository.Specification.CarSpecifications
{
    public class CarSpecification : BaseSpecification<Car>
    {


        public CarSpecification(BaseCarSpecification spec) : base
            (
              car => 
              (string.IsNullOrEmpty(spec.Brand) || car.Brand.Trim().ToLower().Contains(spec.Brand)) &&
              (string.IsNullOrEmpty(spec.Model) || car.Model.Trim().ToLower().Contains(spec.Model))&&
              (string.IsNullOrEmpty(spec.Color) || car.Color.Trim().ToLower().Contains(spec.Color))&&
              (string.IsNullOrEmpty(spec.City) || car.CarAddress.Trim().ToLower().Contains(spec.City))&&
              (string.IsNullOrEmpty(spec.CarStatus) || car.CarStatus == spec._CarStatus)&&
              (!spec.MinPrice.HasValue||car.Price >=spec.MinPrice.Value )&&
              (!spec.MaxPrice.HasValue||car.Price <= spec.MaxPrice.Value)&&
              (!spec.MaxYear.HasValue||car.Year <= spec.MaxYear.Value)&&
              (!spec.MinYear.HasValue||car.Year >= spec.MinYear.Value)
              //(car.carPayment== CarPaymentStatus.Recived)&&
              //(car.IsDeleted == false)


            )
        {
            
       
           
            AddIncludes(p => p.PictureUrl);
            AddIncludes(p => p.Equipments);
            

            


            

        }
        public CarSpecification(string brand, string model) : base
            (
              car =>
              (string.IsNullOrEmpty(brand) || car.Brand.Trim().ToLower().Contains(brand)) &&
              (string.IsNullOrEmpty(model) || car.Model.Trim().ToLower().Contains(model)) 
           
        

            )
        {



            
           







        }

        public CarSpecification(int? id) : base(x => x.Id == id)
        {

            

            AddIncludes(p => p.PictureUrl);
            AddIncludes(p => p.Equipments);

            

        }




    }
}
