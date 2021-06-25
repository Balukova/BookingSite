using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UserRepository : Repository<UserEntity>, IUserRepository<UserEntity>
    {
        BookingDbContext context;
        public UserRepository(BookingDbContext context) : base(context)
        {
            this.context = context;
        }

        public UserEntity GetUserByLoginAndPassword(string login, string password)
        {
            foreach (var user in GetAll())
            {
                if (user.Login.Equals(login) && user.Password.Equals(password)) return user;
            }
            return null;
        }

    }
}
