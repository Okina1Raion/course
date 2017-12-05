using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_CP.ViewModels
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class CreditCardViewModel
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public string FinishDate { get; set; }

        public string CVV { get; set; }

        public int Purpose { get; set; }
    }
}
