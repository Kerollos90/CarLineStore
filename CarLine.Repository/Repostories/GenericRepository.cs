using CarLine.Model.Context;
using CarLine.Model.Entity;
using CarLine.Repository.Interfices;
using CarLine.Repository.Specification;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Repository.Repostories
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        private readonly StoreDbContext _dbContext;

        public GenericRepository(StoreDbContext dbContext )
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(TEntity entity)
        {
          await  _dbContext.Set<TEntity>().AddAsync( entity );

            
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove( entity );
        }

        public async Task<List<TEntity>> GetAllAsync()
          =>  await _dbContext.Set<TEntity>().ToListAsync();


        public async Task<TEntity> GetById(int? Id)
        => await _dbContext.Set<TEntity>().FindAsync(Id);


        public void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update( entity );
        }


        public async Task<TEntity> GetWithSpcificationById(ISpecification<TEntity> specs)
        
          =>  await SpecificationEvaluater<TEntity, TKey>.GetQuery(_dbContext.Set<TEntity>(), specs).FirstOrDefaultAsync();
        


        public async Task<List<TEntity>> GetAllWithSpcificationAsync(ISpecification<TEntity> specs)
           => await SpecificationEvaluater<TEntity, TKey>.GetQuery(_dbContext.Set<TEntity>(), specs).ToListAsync();

    }
}
