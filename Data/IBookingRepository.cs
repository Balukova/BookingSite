using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IBookingRepository<TEntity>:IRepository<TEntity> where TEntity:IBaseEntity
    {
    }
}
