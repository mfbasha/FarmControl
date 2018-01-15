using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Sales
{
    public class SalesOrderStatus
    {
        //Approved Back, rejected, shipped ,Canceled, Issued
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string StatusShortName { get; set; }
        [MaxLength(250)]
        public string StatusDescription { get; set; }
    }
}
