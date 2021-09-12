using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Academy_Backend.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Image { get; set; }
        [StringLength(100)]
        public string Fullname { get; set; }
        [StringLength(100)]
        public string Speciality { get; set; }
        [StringLength(200)]
        public string Desc { get; set; }
    }
}
