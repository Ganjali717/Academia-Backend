using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Academy_Backend.Models
{
    public class Counter
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Icon { get; set; }
        [StringLength(80)]
        public string Title { get; set; }
        [StringLength(100)]
        public string CountDigit { get; set; }
    }
}
