using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers_CP.Enums;

namespace Services_CP.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Login { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public IEnumerable<Role> Roles { get; set; }

        public ICollection<CreditCardViewModel> CreditCards { get; set; }

    }
}
