using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Accounting
{
    public class AccountType
    {
        public int ID { get; set; }
        public string TypeName { get; set; } //Loan, Debit ,staff, Customer, Internal
    }
}
