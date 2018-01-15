using FarmControl.Models.Accounting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Customers
{
    public class Customer
    {
        public Customer()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string CustomerName { get; set; }

        public string CustomerContact { get; set; }
        [MaxLength(250)]
        public string CustomerAddress { get; set; }
        
        public string Address { get; set; }

        public DateTime RelationDate { get; set; }
        public IEnumerable<FinancialAccount> FinancialAccounts { get; set; }

        public DateTime ModfiedDate { get;  }

        //TODO: Add customer AccountNumber
    }
}
