using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess_CP.Entities;

namespace DataAccess_CP.Repositories
{
    public class CreditCardRepository
    {
        CourseProjectDBEntities _context;

        public CreditCardRepository()
        {
            _context = new CourseProjectDBEntities();
        }

        public IEnumerable<CreditCard> GetUserCreditCards(int userId)
        {
            var creditCards = _context.UsersCard.Where(u => u.user_id == userId).ToList();
            var resultCards = new List<CreditCard>();
            creditCards.ForEach(c => resultCards.Add(_context.CreditCard.First(u => u.id == c.card_id)));
            return resultCards;
        }

        public CreditCard GetCreditCard(int id)
        {
            return _context.CreditCard.First(c => c.id == id);
        }

        public void AddOrUpdateCreditCard(CreditCard creditCard)
        {
            _context.CreditCard.AddOrUpdate(creditCard);
            _context.SaveChanges();
        }

        public CreditCard FindCreditCard(string number)
        {
            return _context.CreditCard.First(c => c.number == number);
        }

        public void DeleteCard(int creditCardId)
        {
            _context.CreditCard.Remove(_context.CreditCard.First(c => c.id == creditCardId));
        }
    }
}
