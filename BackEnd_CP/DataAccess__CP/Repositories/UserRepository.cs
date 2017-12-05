using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Helpers_CP.Enums;

namespace DataAccess_CP.Repositories
{
    public class UserRepository
    {
        CourseProjectDBEntities _context;

        public UserRepository()
        {
            _context = new CourseProjectDBEntities();
        }

        public void AddOrUpdateUser(User user)
        {
            _context.User.AddOrUpdate(user);
            _context.SaveChanges();
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.User.ToList();
        }

        public User GetUser(int id)
        {
            return _context.User.Find(id);
        }

        public Role GetUserRole(int id)
        {
            var roleId = _context.UserInRole.FirstOrDefault(c => c.user_id == id)?.role;
            return (Role) roleId;
        }
    }
}
