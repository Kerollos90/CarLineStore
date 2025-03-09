﻿using CarLine.Model.Entity;
using CarLine.Repository.Specification;

namespace CarLine.Repository.Interfices
{
    public interface IGenericRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {

        Task<IReadOnlyList<TEntity>> GetAllAsync();
        Task<TEntity> GetById(int? Id);

        Task<TEntity> GetWithSpcificationById(ISpecification<TEntity> specs);
        Task<IReadOnlyList<TEntity>> GetAllWithSpcificationAsync(ISpecification<TEntity> specs);


        Task AddAsync(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

    }
}