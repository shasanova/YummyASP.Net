using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Yummy.DAL;
using Yummy.Entities;
using Yummy.ViewModels;

namespace Yummy.Controllers
{
    public class HomeController : Controller
    {
        private readonly RelationsYummyDbContext _context;

        public HomeController(RelationsYummyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Chef> chefs = _context.Chefs.Include(c => c.Profession).Include(x => x.ChefSocialMedia).ToList();
            List<Testimonial> testimonials = _context.Testimonials.ToList();
            TestimonialsChefsVM model = new()
            {
                Chefs = chefs,
                Testimonials = testimonials

            };
            return View(model);
        }

    }
}

