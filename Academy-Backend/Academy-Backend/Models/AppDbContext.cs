using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academy_Backend.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Hero> Heros { get; set; }
        public DbSet<Benefits> Benefit { get; set; }
        public DbSet<BenefitCards> BenefitCard { get; set; }
        public DbSet<Counter> Counters { get; set; }
        public DbSet<Cources> Cource { get; set; }
        public DbSet<OnlineCources> OnlineCources { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
