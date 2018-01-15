using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Products
{
    public class Category
    {
        public Category()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string CategoryName { get; set; }
        [MaxLength(250)]
        [DataType(DataType.MultilineText)]
        public string  CategoryDescription{ get; set; }

        public DateTime ModfiedDate { get;  }
    }
}
