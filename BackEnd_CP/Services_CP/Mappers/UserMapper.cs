using DataAccess_CP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess_CP.Entities;
using Helpers_CP.Enums;
using Services_CP.ViewModels;

namespace Services_CP.Mappers
{
    public class UserMapper
    {
        public static UserViewModel EntityToModel(User userEntity)
        {
            return userEntity == null ? null :
                new UserViewModel
                {
                    Id = userEntity.id,
                    Name = userEntity.Name,
                    Email = userEntity.Email,
                    Login = userEntity.Login,
                    Password = userEntity.Password,
                    Roles = userEntity.UserInRole.Select(r => (Role)r.role)
                };
        }

        public static User ModelToEntity(UserViewModel userViewModel)
        {
            return userViewModel == null ? null :
                new User
                {
                    id = userViewModel.Id,
                    Name = userViewModel.Name,
                    Email = userViewModel.Email,
                    Login = userViewModel.Login,
                    Password = userViewModel.Password
                };
        }
    }
}
