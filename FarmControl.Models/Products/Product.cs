using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Products
{
    public class Product
    {
        public Product()
        {
            ModfiedDate = DateTime.Now.Date;
        }

        [Key]
        [MaxLength(16)]
        public string Barcode { get; set; }
        [Required]
        [MaxLength(50)]
        public string ProductName { get; set; }
        [MaxLength(250)]
        public string ProductDescription { get; set; }
        [Required]
        [EnumDataType(typeof(Category))]
        public Category ProductCategory { get; set; }
        [MaxLength(15)]
        public string ProductColor { get; set; }

        //TODO: Add code for saving product Image to database - search on google
        [Required]
        public int CurrentStockLevel { get; set; }
        [DefaultValue(0)]
        public int SaftyStockLevel { get; set; }

        [DataType(DataType.Currency)]
        public double  StandardCost { get; set; }

        [DataType(DataType.Currency)]
        public double UnitPrice { get; set; }

        [DataType(DataType.Upload)]
        public byte[] ProductImage { get; set; }

        public DateTime ModfiedDate { get;  }
    }
    public enum ProductQuality
    {
        High,Medium,Low
    }
    public enum MeasureUnit
    {
        kilogram, liter,Package,Piece
    }
}
