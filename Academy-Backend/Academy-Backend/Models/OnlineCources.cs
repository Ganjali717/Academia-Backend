using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Academy_Backend.Models
{
    public class OnlineCources
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Logo { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(100)]
        public string Count { get; set; }
    }
}
