using Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab1.Controllers
{
    public enum Operators
    {
        ADD, SUB, MUL, DIV
    }

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

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

        public IActionResult About([FromQuery(Name = "app-author")]string author)
        {
            //string author = Request.Query["author"];
            ViewBag.Author = author;
            return View();
        }

        public IActionResult Calculator([FromQuery(Name = "app-author")]Operators op, double? l1, double? l2)
        {
            if (l1 == null || l2 == null)
            {
                return View("Error");
            }
            switch (op)
            {
                case Operators.ADD:
                    ViewBag.result = l1+l2;
                    break;
                case Operators.SUB:
                    ViewBag.result = l1-l2;
                    break;
                case Operators.MUL:
                    ViewBag.result = l1*l2;
                    break;
                case Operators.DIV:
                    ViewBag.result = l2/l1;
                    break;
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}