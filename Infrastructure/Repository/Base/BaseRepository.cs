using Domain.Interfaces.Base;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository.Base
{
    public class BaseRepository<TEntity> : IBaseInterface<TEntity>, IDisposable where TEntity : class
    {

        private readonly DbContextOptions<DataBaseContext> _dbContextOptions;

        public BaseRepository()
        {
            _dbContextOptions = new DbContextOptions<DataBaseContext>();
        }

        public void Add(TEntity entity)
        {
            using (var context = new DataBaseContext(_dbContextOptions))
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

        public IList<TEntity> GetEntities()
        {
            using (var context = new DataBaseContext(_dbContextOptions))
            {
                return context.Set<TEntity>().AsNoTracking().ToList();
            }
        }

        public TEntity GetEntityById(int id)
        {
            using (var context = new DataBaseContext(_dbContextOptions))
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new DataBaseContext(_dbContextOptions))
            {
                context.Set<TEntity>().Update(entity);
                context.SaveChanges();
            }
        }

        public void Remove(TEntity entity)
        {
            using (var context = new DataBaseContext(_dbContextOptions))
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
