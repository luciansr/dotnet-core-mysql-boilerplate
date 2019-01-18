using System;
using System.Collections.Generic;
using Models;
using Repository.UnitOfWork;

namespace Services
{
    public class UserService
    {
        private IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            return _unitOfWork.Users.GetAll();
        }

        public UserDTO GetUserById(int id)
        {
            return _unitOfWork.Users.GetUserById(id);
        }
    }
}
