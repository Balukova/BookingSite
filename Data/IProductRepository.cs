using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Data
{
    public interface IProductRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity: IBaseEntity
    {
    }
}
