using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.DbContexts;
using UserAPI.Entity;

namespace UserAPI.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }

        public void AddUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            _context.Users.Add(user);
        }

        public void DeleteUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            _context.Users.Remove(user);
        }

        public User GetUser(string userName)
        {
            if (userName == String.Empty)
                throw new ArgumentNullException(nameof(userName));

            return _context.Users.Where(u => u.Name == userName).FirstOrDefault();
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.OrderBy(u => u.Name).ToList();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateUser(User user)
        {
            // implemented
        }
        
        public bool UserExists(string userName)
        {
            if (userName == String.Empty)
                throw new ArgumentNullException(nameof(userName));

            return _context.Users.Any(u => u.Name == userName);
        }

    }
}
