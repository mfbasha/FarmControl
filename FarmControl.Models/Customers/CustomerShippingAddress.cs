using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Customers
{
    public class CustomerShippingAddress
    {
        public CustomerShippingAddress()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public string Address { get; set; }
        [MaxLength(10)]
        public string PostalCode { get; set; }
        [EnumDataType(typeof(AddressType))]
        public AddressType AddressType { get; set; }

        public DateTime ModfiedDate { get;  }

    }
    public enum AddressType
    {
        Billing,Shipping
    }
}
