using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Work
{
    public class OperationCostItem
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string ItemName { get; set; }
        [MaxLength(250)]
        public string ItemDescription { get; set; }
    }
}
