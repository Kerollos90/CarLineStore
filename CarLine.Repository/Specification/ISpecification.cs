using CarLine.Model.Entity;
using System.Linq.Expressions;

namespace CarLine.Repository.Specification
{
    public interface ISpecification<T> 
    {

        Expression<Func<T, bool>> Criteria { get; }

        List<Expression<Func<T, object>>> Includes { get; }
    }
}