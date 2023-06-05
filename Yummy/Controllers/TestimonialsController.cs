using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Yummy.Controllers
{
    public class TestimonialsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

