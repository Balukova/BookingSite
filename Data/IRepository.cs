using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IRepository<TEntity> where TEntity: IBaseEntity
    {
        void Create(TEntity entity);

        TEntity GetById(int id);
        void Update(TEntity entity);
        void DeleteById(int id);
        IList<TEntity> GetAll();
    }
}
