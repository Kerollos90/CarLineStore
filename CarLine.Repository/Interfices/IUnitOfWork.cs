using CarLine.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Repository.Interfices
{
    public interface IUnitOfWork
    {
        Task<int> CompleteAsync();

        IGenericRepository<TEntity,TKey> Repository<TEntity,TKey>() where TEntity : BaseEntity<TKey>;

    }
}
