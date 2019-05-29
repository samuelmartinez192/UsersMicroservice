using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersMicroservice.DBContexts;
using UsersMicroservice.Models;

namespace UsersMicroservice.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _dbContext;

        public UserRepository(UserContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteUser(int UserId)
        {
            var user = _dbContext.Users.Find(UserId);
            _dbContext.Users.Remove(user);
            Save();
        }

        public User GetUserByID(int UserId)
        {
            return _dbContext.Users.Find(UserId);
        }

        public IEnumerable<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }

        public void InsertUser(User user)
        {
            _dbContext.Add(user);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _dbContext.Entry(user).State = EntityState.Modified;
            Save();
        }
    }
}
