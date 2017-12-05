using System.Collections.Generic;
using System.Web.Http;
using System.Web.UI.WebControls;
using Helpers_CP.Enums;
using Services_CP.Services;
using Services_CP.ViewModels;

namespace BackEnd_CP.Controllers
{
    public class UserRoleController : ApiController
    {
        readonly UserService _unitOfWork;

        public UserRoleController()
        {
            _unitOfWork = new UserService();
        }

        public Role GetUserRole(int id)
        {
            return _unitOfWork.GetUserRole(id);
        }

        public void ChangeUserRole([FromBody]dynamic newRole)
        {
            _unitOfWork.ChangeUserRole(newRole.id, newRole.role);
        }
    }
}
