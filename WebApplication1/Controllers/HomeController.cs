using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        static List<Beer> beers = new()
        {
                new Beer { Id = 1, Price = 45, Brand = "Heineken", Category = "Lager", Countryoforigin = "Netherlands", Package = "Bottle 0.5L" },
                new Beer { Id = 2, Price = 40, Brand = "Budweiser", Category = "Lager", Countryoforigin = "USA", Package = "Can 0.5L" },
                new Beer { Id = 3, Price = 38, Brand = "Carlsberg", Category = "Pilsner", Countryoforigin = "Denmark", Package = "Bottle 0.5L" },
                new Beer { Id = 4, Price = 50, Brand = "Guinness", Category = "Stout", Countryoforigin = "Ireland", Package = "Bottle 0.33L" },
                new Beer { Id = 5, Price = 42, Brand = "Corona Extra", Category = "Lager", Countryoforigin = "Mexico", Package = "Bottle 0.33L" },
                new Beer { Id = 6, Price = 47, Brand = "Leffe Blonde", Category = "Abbey Ale", Countryoforigin = "Belgium", Package = "Bottle 0.33L" },
                new Beer { Id = 7, Price = 35, Brand = "Zhiguli", Category = "Lager", Countryoforigin = "Russia", Package = "Bottle 0.5L" },
                new Beer { Id = 8, Price = 39, Brand = "Lvivske 1715", Category = "Lager", Countryoforigin = "Ukraine", Package = "Bottle 0.5L" },
                new Beer { Id = 9, Price = 41, Brand = "Stella Artois", Category = "Pilsner", Countryoforigin = "Belgium", Package = "Can 0.5L" },
                new Beer { Id = 10, Price = 55, Brand = "Hoegaarden", Category = "Witbier", Countryoforigin = "Belgium", Package = "Bottle 0.33L" },
                new Beer { Id = 11, Price = 37, Brand = "Kozel", Category = "Dark Lager", Countryoforigin = "Czech Republic", Package = "Can 0.5L" },
                new Beer { Id = 12, Price = 44, Brand = "Tsingtao", Category = "Lager", Countryoforigin = "China", Package = "Bottle 0.33L" },
                new Beer { Id = 13, Price = 48, Brand = "Asahi", Category = "Super Dry", Countryoforigin = "Japan", Package = "Bottle 0.33L" },
                new Beer { Id = 14, Price = 36, Brand = "Obolon Premium", Category = "Lager", Countryoforigin = "Ukraine", Package = "Bottle 0.5L" },
                new Beer { Id = 15, Price = 52, Brand = "Paulaner", Category = "Weissbier", Countryoforigin = "Germany", Package = "Bottle 0.5L" }
            };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult AdminPanel()
        {
            return View(beers);
        }

        public IActionResult Delete(int id)
        {
            var item = beers.Find(x => x.Id == id);

            if (item == null)
                return NotFound(); // 404

            beers.Remove(item);
            return RedirectToAction("AdminPanel");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
