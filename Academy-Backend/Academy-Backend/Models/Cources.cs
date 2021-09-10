using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Academy_Backend.Models
{
    public class Cources
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Logo { get; set; }
        [StringLength(100)]
        public string Desc { get; set; }
        [StringLength(100)]
        public string Price { get; set; }
        [StringLength(100)]
        public string Teacher { get; set; }
        public string Stars { get; set; }
        [StringLength(1000)]
        public string LectureTime { get; set; }
        [StringLength(100)]
        public string RedirectUrl { get; set; }
        [StringLength(100)]
        public string Img { get; set; }
    }
}
