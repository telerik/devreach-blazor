using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevReach.Shared
{
    public class Gig
    {
        [Required]
        public string Location { get; set; }
        [Required]
        public DateTime? Date { get; set; }
        [Range(5, 1000)]
        public decimal Payment { get; set; }
        public bool HasBeenPaid { get; set; }
    }
}
