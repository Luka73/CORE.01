using Microsoft.EntityFrameworkCore;
using Project.Domain.Contracts.Repositories;
using Project.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Infrastructure.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        private readonly DataContext context;
        public BaseRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public List<TEntity> FindAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public List<TEntity> FindAll(Func<TEntity, bool> where)
        {
            return context.Set<TEntity>().Where(where).ToList();
        }

        public TEntity FindById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public TEntity FindOne(Func<TEntity, bool> where)
        {
            return context.Set<TEntity>().FirstOrDefault(where);
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
