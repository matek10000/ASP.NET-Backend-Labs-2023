using Lab3___Aplikacja.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3___Aplikacja.Controllers
{
    public class KontaktController : Controller
    {
        static Dictionary<int, Kontakt> _kontakty = new Dictionary<int, Kontakt>();
        static int index = 1;
        public IActionResult Index()
        {
            return View(_kontakty);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Kontakt model)
        {
            if (ModelState.IsValid)
            {
                model.Id = index++;
                _kontakty.Add(model.Id, model);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_kontakty[id]);
        }

        [HttpPost]
        public IActionResult Update(Kontakt model)
        {
            if (ModelState.IsValid)
            {
                _kontakty[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_kontakty[id]);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_kontakty[id]);
        }

    }
}
