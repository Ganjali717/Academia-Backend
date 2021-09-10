
using Academy_Backend.Models;
using Academy_Backend.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Academy_Backend.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Hero> hero = _context.Heros.ToList();
            List<Benefits> benefits = _context.Benefit.ToList();
            List<BenefitCards> benefitcards = _context.BenefitCard.ToList();
            List<Counter> counter = _context.Counters.ToList();
            List<Cources> cources = _context.Cource.ToList();
            List<OnlineCources> onlinecource = _context.OnlineCources.ToList();


            HomeViewModel homeVM = new HomeViewModel
            {
                Heros = hero,
                Benefit = benefits,
                BenefitCard = benefitcards,
                Counters = counter,
                Cource = cources,
                OnlineCource = onlinecource
            };

            return View(homeVM);
        }
    }
}
