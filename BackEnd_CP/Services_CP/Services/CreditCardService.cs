using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess_CP.Repositories;
using Services_CP.Mappers;
using Services_CP.ViewModels;

namespace Services_CP.Services
{
    public class CreditCardService
    {
        private readonly CreditCardRepository _creditCardRepository;

        public CreditCardService()
        {
            _creditCardRepository = new CreditCardRepository();
        }

        public CreditCardViewModel GetCreditCard(int id)
        {
            return CreditCardMapper.EntityToModel(_creditCardRepository.GetCreditCard(id));
        }

        public void AddOrUpdateCreditCard(CreditCardViewModel creditCardViewModel)
        {
            _creditCardRepository.AddOrUpdateCreditCard(CreditCardMapper.ModelToEntity(creditCardViewModel));
        }

        public void DeleteCard(int creditCardId)
        {
            _creditCardRepository.DeleteCard(creditCardId);
        }
    }
}
