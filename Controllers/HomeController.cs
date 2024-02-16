using Microsoft.AspNetCore.Mvc;
using Mission6_Murdock.Models;
using System.Diagnostics;

namespace Mission6_Murdock.Controllers
{
    public class HomeController : Controller
    {

        private FormContext _context;
        public HomeController(FormContext temp) 
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Application response) 
        {
            _context.Applications.Add(response);
            _context.SaveChanges();
            return View("Confirmation");
        }
    }
}
