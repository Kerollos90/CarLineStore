using CarLine.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Repository.Specification
{
    public class SpecificationEvaluater<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {

        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> specs)
        {
            var query = inputQuery;

            if (specs.Criteria != null)
            {
                query = query.Where(specs.Criteria);
            }

            
            query = specs.Includes.Aggregate(query, (current, include) => current.Include(include));

            return query;
        }

    }
}
