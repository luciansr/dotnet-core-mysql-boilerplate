using System;
using System.Collections.Generic;
using System.Linq;
using DatabaseModels.Models;
using Microsoft.EntityFrameworkCore;
using Models;
using Repository.Context;

namespace Repository.Repositories
{
    public class UserRepository
    {
        private DbSet<User> _dbSet;

        public UserRepository(AppDbContext context)
        {
            _dbSet = context.Users;
        }
        public UserDTO GetUserById(int id)
        {
            return _dbSet.Where(u => u.Id == id).Select(u => new UserDTO {
                Id = u.Id,
                Username = u.Username,
                Name = u.Name
            }).FirstOrDefault();
        }

        public IEnumerable<UserDTO> GetAll()
        {
            return _dbSet.Select(u => new UserDTO {
                Id = u.Id,
                Username = u.Username,
                Name = u.Name
            }).ToList();
        }
    }
}