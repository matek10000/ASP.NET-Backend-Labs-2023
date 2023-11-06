using Lab3___Aplikacja.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3___Aplikacja.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> _produkty = new List<Product>();
        private static int index = 1;

        public IActionResult Index()
        {
            return View(_produkty);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new Product(); // Tworzenie nowego obiektu Produkt
            return View(model); // Zwracanie widoku z modelem
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                model.Id = index++;
                _produkty.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Update(int id)
        {
            Product produkt = _produkty.FirstOrDefault(p => p.Id == id);

            if (produkt == null)
            {
                return RedirectToAction("Index");
            }

            return View(produkt);
        }

        [HttpPost]
        public IActionResult Update(Product model)
        {
            if (ModelState.IsValid)
            {
                Product produkt = _produkty.FirstOrDefault(p => p.Id == model.Id);

                if (produkt != null)
                {
                    // Zaktualizuj dane produktu
                    produkt.Nazwa = model.Nazwa;
                    produkt.Cena = model.Cena;
                    produkt.Producent = model.Producent;
                    produkt.DataProdukcji = model.DataProdukcji;
                    produkt.Opis = model.Opis;

                    return RedirectToAction("Index");
                }
            }

            return View(model);
        }

        public IActionResult Details(int id)
        {
            Product produkt = _produkty.FirstOrDefault(p => p.Id == id);

            if (produkt == null)
            {
                return RedirectToAction("Index");
            }

            return View(produkt);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var produkt = _produkty.FirstOrDefault(k => k.Id == id);
            if (produkt != null)
            {
                _produkty.Remove(produkt);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}
