using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Entity;

namespace UserAPI.Services
{
    public interface IUserRepository
    {
        User GetUser(string userName);
        IEnumerable<User> GetUsers();
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);

        bool UserExists(string userName);
        bool Save();
    }
}
