using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IProductInShopRepository<TEntity>: IRepository<TEntity> where TEntity: IBaseEntity
    {
        IList<TEntity> GetProductInShopsByProductName(string name);

        void DecreaseQuantity(TEntity entity);
        void IncreaseQuantity(TEntity entity);
    }
}
