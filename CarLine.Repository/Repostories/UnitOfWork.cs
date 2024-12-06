using CarLine.Model.Context;
using CarLine.Model.Entity;
using CarLine.Repository.Interfices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Repository.Repostories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreDbContext _dbContext;
        private  Hashtable _repository;

        public UnitOfWork(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CompleteAsync()
        => await _dbContext.SaveChangesAsync();

        public IGenericRepository<TEntity, TKey> Repository<TEntity, TKey>() where TEntity : BaseEntity<TKey>
        {
            if (_repository is null)
                _repository = new Hashtable();

            var entityKey = typeof(TEntity).Name;

            if (!_repository.ContainsKey(entityKey))
            {
                var enitityType = typeof(GenericRepository<,>);
                var entityInstance = Activator.CreateInstance(enitityType.MakeGenericType(typeof(TEntity),typeof(TKey)),_dbContext);

                _repository.Add(entityKey, entityInstance);

            }

            return  (IGenericRepository<TEntity, TKey>)_repository[entityKey];
        }
    }
}
