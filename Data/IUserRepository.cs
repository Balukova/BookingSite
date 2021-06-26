using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IUserRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity: IBaseEntity
    {
        TEntity GetUserByLoginAndPassword(string login, string password);
    }
}
