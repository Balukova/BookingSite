using Models;
using Data;
using Mappers;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UserService : IUserService
    {
        private IUnitOfWork unitOfWork;
        private IMapper<User, UserEntity> userMapper;
        public UserService(IUnitOfWork unitOfWork, IMapper<User, UserEntity> userMapper)
        {
            this.unitOfWork = unitOfWork;
            this.userMapper = userMapper;
        }

        public User GetUserByLoginAndPassword(string login, string password)
        {
            return userMapper.ToModel(unitOfWork.UserRepository.GetUserByLoginAndPassword(login, password));
        }
    }
}
