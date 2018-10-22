using System.Linq;
using Microsoft.EntityFrameworkCore;
using Repository.DbModels;

namespace Repository.Repositories
{
    public class UserRepository
    {
        private DbSet<User> _dbSet;

        public UserRepository(DbSet<User> dbSet)
        {
            _dbSet = dbSet;
        }
        public string GetUsernameById(int id)
        {
            return _dbSet.Where(u => u.Id == id).FirstOrDefault()?.Username;
        }
    }
}