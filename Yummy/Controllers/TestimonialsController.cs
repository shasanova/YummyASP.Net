using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Yummy.DAL;
using Yummy.Entities;

namespace Yummy.Controllers
{
    public class TestimonialsController : Controller
    {

        private readonly RelationsYummyDbContext _context;

        public TestimonialsController(RelationsYummyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Testimonial> testimonials = _context.Testimonials.ToList();
            return View(testimonials);
        }


        public IActionResult Details(int id)
        {
            if (id <= 0) return BadRequest();
            Testimonial testimonial = _context.Testimonials.FirstOrDefault(x => x.Id == id); ;
            if (testimonial is null) return NotFound();
            return View(testimonial);
        }

    }
}

