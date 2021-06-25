using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Mappers
{
    public class UserMapper : IMapper<User, UserEntity>
    {

        public User ToDomain(UserEntity entity)
        {
            if (entity == null) return null;
            return new User { Id = entity.Id, Login = entity.Login, Password = entity.Password };
        }

        public UserEntity ToEntity(User domain)
        {
            return new UserEntity { Id = domain.Id, Login = domain.Login, Password = domain.Password };
        }
    }
}
