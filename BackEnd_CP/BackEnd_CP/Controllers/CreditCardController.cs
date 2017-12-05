using System.Collections.Generic;
using System.Web.Http;
using Services_CP.Services;
using Services_CP.ViewModels;

namespace BackEnd_CP.Controllers
{
    public class CreditCardController : ApiController
    {
        readonly CreditCardService _unitOfWork;

        public CreditCardController()
        {
            _unitOfWork = new CreditCardService();
        }
        //api/CreditCard/4
        public CreditCardViewModel GetCreditCard(int id)
        {
            return _unitOfWork.GetCreditCard(id);
        }

        public void Post([FromBody] CreditCardViewModel creditCardViewModel)
        {
            _unitOfWork.AddOrUpdateCreditCard(creditCardViewModel);
        }

        public void Delete(int creditCardId)
        {
            _unitOfWork.DeleteCard(creditCardId);
        }
    }
}
