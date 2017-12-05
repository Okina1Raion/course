using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess_CP.Repositories;
using Helpers_CP.Enums;
using Services_CP.Mappers;
using Services_CP.ViewModels;

namespace Services_CP.Services
{
    public class UserService
    {
        readonly UserRepository _userRepository;
        readonly CreditCardRepository _creditCardRepository; 

        public UserService()
        {
            _userRepository = new UserRepository();
            _creditCardRepository = new CreditCardRepository();
        }
        public IEnumerable<UserViewModel> GetUsers()
        {
            return _userRepository.GetUsers().Select(UserMapper.EntityToModel);
        }

        public UserViewModel GetUser(int id)
        {
            return UserMapper.EntityToModel(_userRepository.GetUser(id));
        }

        public int AddOrUpdateUser(UserViewModel user)
        {
            return  _userRepository.AddOrUpdateUser(UserMapper.ModelToEntity(user));
        }

        public Role GetUserRole(int id)
        {
            return _userRepository.GetUserRole(id);
        }

        public IEnumerable<CreditCardViewModel> GetUserCreditCards(int userId)
        {
            return _creditCardRepository.GetUserCreditCards(userId).Select(CreditCardMapper.EntityToModel);
        }

        public void ChangeUserRole(int id, Role newRole)
        {
            _userRepository.ChangeUserRole(id, newRole);
        }

        public void AddUserCard(int userId, int cardId, int purpose)
        {
            _userRepository.AddUserCard(userId, cardId, purpose);
        }

        public void AddUserCard(int userId, CreditCardViewModel cardViewModel, int purpose)
        {
            _creditCardRepository.AddOrUpdateCreditCard(CreditCardMapper.ModelToEntity(cardViewModel));
            var card = _creditCardRepository.FindCreditCard(cardViewModel.Number);
            _userRepository.AddUserCard(userId, card.id, purpose);
        }
    }
}
