using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersMicroservice.Models;

namespace UsersMicroservice.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();

        User GetUserByID(int UserId);

        void InsertUser(User user);

        void DeleteUser(int UserId);

        void UpdateUser(User user);

        void Save();
    }
}
