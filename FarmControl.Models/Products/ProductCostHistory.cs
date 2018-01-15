using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Products
{
    public class ProductCostHistory
    {
        public ProductCostHistory()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        public int Id { get; set; }
        public Product Product { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public double Cost { get; set; }
        public DateTime ModfiedDate { get; }
    }
}
