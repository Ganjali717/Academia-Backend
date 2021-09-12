using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Academy_Backend.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Image { get; set; }
        [StringLength(100)]
        public string Item { get; set; }
        [StringLength(150)]
        public string Desc { get; set; }
        [StringLength(100)]
        public string Icon1 { get; set; }
        [StringLength(100)]
        public string Icon2 { get; set; }
        [StringLength(100)]
        public string Icon3 { get; set; }
    }
}
