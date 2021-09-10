using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Academy_Backend.Models
{
    public class BenefitCards
    {
        public int Id { get; set; }
        [StringLength(150)]
        public string Icon { get; set; }
        [StringLength(150)]
        public string Title { get; set; }
        [StringLength(150)]
        public string Desc { get; set; }
    }
}
