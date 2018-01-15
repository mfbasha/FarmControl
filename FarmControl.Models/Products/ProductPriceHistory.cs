using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Products
{
    public class ProductPriceHistory
    {
        public ProductPriceHistory()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        public int Id { get; set; }
        public Product Product { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public double Price { get; set; }
        public DateTime ModfiedDate { get; }
    }
}
