using CarLine.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Repository.Specification.CarShowRoomSpecifications
{
    public class CarShowRoomSpecification : BaseSpecification<CarShowRoom>
    {
        public CarShowRoomSpecification() : base()        
        {
            AddIncludes(p => p.Car);
            AddIncludes(p => p.PictureUrl);
            AddIncludes(p => p.Phone);
            AddIncludes(p => p.Address);

        }

        public CarShowRoomSpecification(int id ) : base(p => p.Id == id)
        {
            AddIncludes(p => p.Car);
            AddIncludes(p => p.PictureUrl);
            AddIncludes(p => p.Phone);
            AddIncludes(p => p.Address);

        }

    }
}
