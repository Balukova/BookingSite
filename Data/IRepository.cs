using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IRepository<TEntity, TKey> where TEntity: IBaseEntity
    {
        void Create(TEntity entity);
        TEntity GetById(TKey id);
        void Update(TEntity entity);
        void DeleteById(TKey id);
        IList<TEntity> GetAll();
    }
}
