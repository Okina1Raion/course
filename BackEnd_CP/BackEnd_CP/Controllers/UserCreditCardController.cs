using System.Collections.Generic;
using System.Web.Http;
using System.Web.UI.WebControls;
using Helpers_CP.Enums;
using Services_CP.Services;
using Services_CP.ViewModels;

namespace BackEnd_CP.Controllers
{
    public class UserCreditCardController : ApiController
    {
        readonly UserService _unitOfWork;

        public UserCreditCardController()
        {
            _unitOfWork = new UserService();
        }

        // POST api/values
        public void Post([FromBody]dynamic user)
        {
            _unitOfWork.AddOrUpdateUser(user);
        }

        public IEnumerable<CreditCardViewModel> GetUserCreditCards(int userId)
        {
            return _unitOfWork.GetUserCreditCards(userId);
        }

        public void AddUserCard([FromBody] dynamic req)
        {
            _unitOfWork.AddUserCard(req.userId, req.cardId, req.purpose);
        }
    }
}
