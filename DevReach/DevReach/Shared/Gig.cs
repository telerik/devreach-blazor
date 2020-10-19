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
        public int Id { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public DateTime Date { get; set; }
        
        [Range(5, 1000)]
        public double Payment { get; set; }
        
        public bool HasBeenPaid { get; set; }
    }
}
