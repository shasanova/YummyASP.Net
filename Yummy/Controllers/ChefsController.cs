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
    public class ChefsController : Controller
    {
        private readonly RelationsYummyDbContext _context;

        public ChefsController(RelationsYummyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Chef> chefs = _context.Chefs.Include(c=>c.Profession).Include(x=>x.ChefSocialMedia).ToList();
            return View(chefs);
        }

        public IActionResult Details(int id)
        {
            if (id <= 0) return BadRequest();
            Chef chef = _context.Chefs.Include(c => c.Profession).Include(x => x.ChefSocialMedia).FirstOrDefault(x => x.Id == id); ;
            if (chef is null) return NotFound();
            return View(chef);
        }


    }
}

