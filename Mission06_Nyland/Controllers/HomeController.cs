using Microsoft.AspNetCore.Mvc;
using Mission06_Nyland.Models;
using System.Diagnostics;

namespace Mission06_Nyland.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext _context;
        public HomeController(MovieFormContext temp) 
        { 
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Form response)
        { 
            _context.Forms.Add(response);
            _context.SaveChanges();

            return View("Index", response); 
        }
    }
}
