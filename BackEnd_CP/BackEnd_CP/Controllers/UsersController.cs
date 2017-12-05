using System.Collections.Generic;
using System.Web.Http;
using System.Web.UI.WebControls;
using Helpers_CP.Enums;
using Services_CP.Services;
using Services_CP.ViewModels;

namespace BackEnd_CP.Controllers
{
    public class UsersController : ApiController
    {
        readonly UserService _unitOfWork;

        public UsersController()
        {
            _unitOfWork = new UserService();
        }

        // GET api/values
        public IEnumerable<UserViewModel> GetAll()
        {
            return _unitOfWork.GetUsers();
        }

        // GET api/values/5
        public UserViewModel GetUser(int id)
        {
            return _unitOfWork.GetUser(id);
        }

        // POST api/values
        public void Post([FromBody]UserViewModel user)
        {
            _unitOfWork.AddOrUpdateUser(user);
        }

    }
}
