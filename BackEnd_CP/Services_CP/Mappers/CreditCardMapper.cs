using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess_CP.Entities;
using Services_CP.ViewModels;

namespace Services_CP.Mappers
{
    public static class CreditCardMapper
    {
        public static CreditCardViewModel EntityToModel(CreditCard creditCardEntity)
        {
            return creditCardEntity == null
                ? null
                : new CreditCardViewModel()
                {
                    Id = creditCardEntity.id,
                    Number = creditCardEntity.number,
                    CVV = creditCardEntity.CVV,
                    FinishDate = creditCardEntity.finish_date,
                    Purpose = creditCardEntity.UsersCard.First(c => c.card_id == creditCardEntity.id).purpose
                };
        }

        public static CreditCard ModelToEntity(CreditCardViewModel creditCardViewModel)
        {
            return creditCardViewModel == null
                ? null
                : new CreditCard()
                {
                    id = creditCardViewModel.Id,
                    number = creditCardViewModel.Number,
                    CVV = creditCardViewModel.CVV,
                    finish_date = creditCardViewModel.FinishDate
                };
        }
    }
}
