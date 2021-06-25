using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers
{
    public interface IMapper<TDomain, TEntity>
    {
        TDomain ToDomain(TEntity entity);
        TEntity ToEntity(TDomain domain);
    }
}
