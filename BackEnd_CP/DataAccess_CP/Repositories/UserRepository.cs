using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using DataAccess_CP.Entities;
using Helpers_CP.Enums;

namespace DataAccess_CP.Repositories
{
    public class UserRepository
    {
        readonly CourseProjectDBEntities _context;

        public UserRepository()
        {
            _context = new CourseProjectDBEntities();
        }

        public int AddOrUpdateUser(User user)
        {
            if (user.id == 0) _context.User.AddOrUpdate(user);
            else _context.User.AddOrUpdate(user);
            return  _context.SaveChanges();
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
            return (Role)roleId;
        }

        public void ChangeUserRole(int id, Role newRole)
        {
            var userInRoleOld = _context.UserInRole.First(u => u.user_id == id);
            var userInRole = new UserInRole()
            {
                user_id = id,
                isActive = userInRoleOld.isActive,
                role = (int)newRole
            };
            _context.UserInRole.AddOrUpdate(userInRole);
            _context.SaveChanges();
        }

        public void AddUserCard(int userId, int cardId, int purpose)
        {
            _context.UsersCard.Add(new UsersCard()
            {
                card_id = cardId,
                user_id = userId,
                purpose = purpose
            });
        }
    }
}
