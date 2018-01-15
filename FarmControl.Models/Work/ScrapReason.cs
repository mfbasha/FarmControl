using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Work
{
    public class ScrapReason
    {
        public ScrapReason()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        [Key]
        public int ScrapReasonID { get; set; }
        [Required]
        public string ScrapDescription { get; set; }

        public DateTime ModfiedDate { get;  }
    }
}
