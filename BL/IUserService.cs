using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace BL
{
    public interface IUserService
    {
        User GetUserByLoginAndPassword(string login, string password);
    }
}
