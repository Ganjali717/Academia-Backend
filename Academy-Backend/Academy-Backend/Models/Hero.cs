using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Academy_Backend.Models
{
    public class Hero
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(150)]
        public string Desc { get; set; }
        [StringLength(200)]
        public string Image { get; set; }
        [StringLength(100)]
        public string RedirectUrl { get; set; }
        [StringLength(100)]
        public string RedirectUrlSecond { get; set; }

    }
}
