using Academy_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academy_Backend.ViewModels
{
    public class HomeViewModel
    {
        public List<Hero> Heros { get; set; }
        public List<Benefits> Benefit { get; set; }
        public List<BenefitCards> BenefitCard { get; set; }
        public List<Counter> Counters { get; set; }
        public List<Cources> Cource { get; set; }
        public List<OnlineCources> OnlineCource { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
