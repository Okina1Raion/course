//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DataAccess_CP.Entities;

namespace DataAccess_CP
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsersCard
    {
        public int user_id { get; set; }
        public int card_id { get; set; }
        public int purpose { get; set; }
    
        public virtual CreditCard CreditCard { get; set; }
        public virtual User User { get; set; }
    }
}
