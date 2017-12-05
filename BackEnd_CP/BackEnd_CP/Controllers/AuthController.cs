using System.Collections.Generic;
using System.Web.Http;
using System.Web.UI.WebControls;
using Helpers_CP.Enums;
using Services_CP.Services;
using Services_CP.ViewModels;

namespace BackEnd_CP.Controllers
{
    public class AuthController : ApiController
    {
        readonly UserService _unitOfWork;

        public AuthController()
        {
            _unitOfWork = new UserService();
        }

        // POST api/values
        [HttpPost]
        public IHttpActionResult Post([FromBody]UserViewModel user)
        {
            return Ok(_unitOfWork.AddOrUpdateUser(user));
        }

        public IHttpActionResult GetUsers()
        {
            return Json(new { user = "not user" });
        }
    }
}
