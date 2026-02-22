using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tapsirig1.Models;

namespace tapsirig1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Teacher t = new Teacher()
            {
                date_of_birth = 1835,
                Name = "Mark",
                Surname = "Twain"
            };
            Book b = new Book()
            {
                year_of_publication = 1884,
                Title = "The Adventures of Huckleberry Finn",
                Author = "Mark Twain"
            };
            HomeViewmodel model = new HomeViewmodel()
            {
                Teacher = t,
                Book = b
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
