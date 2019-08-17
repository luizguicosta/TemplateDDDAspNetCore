using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interface
{
    public interface IBaseApplication<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        TEntity GetEntityById(int id);
        IList<TEntity> GetEntities();
        void Remove(TEntity entity);
    }
}
