using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Customers
{
    public class CustomerContact
    {
        public CustomerContact()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer Customer { get; set; }

        [Required]
        [EnumDataType(typeof(ContactType))]
        public ContactType ContactType { get; set; }

        public DateTime ModfiedDate { get;  }
    }
    public enum ContactType
    {
        LandLine, Mobile,Email,Fax
    }
}
