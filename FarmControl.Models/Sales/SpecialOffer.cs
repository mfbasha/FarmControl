using FarmControl.Models.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Sales
{
    public class SpecialOffer
    {
        public SpecialOffer()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        [Key]
        public int SpecialOfferID { get; set; }
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
        [DefaultValue(0)]
        public double DiscountPct { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Product Product { get; set; }
        public int MinQty { get; set; }
        public int MaxQty { get; set; }

        public DateTime ModfiedDate { get;  }


    }
}
