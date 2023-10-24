using Lab3___Aplikacja.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3___Aplikacja.Controllers
{
    public class KontaktController : Controller
    {
        static List<Kontakt> _kontakty = new List<Kontakt>();
        static int index = 1;

        private readonly IContactService _contactService;

        public KontaktController(IContactService contactService)
        {
            _contactService = contactService;
        }

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
                _contactService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var kontakt = _kontakty.FirstOrDefault(k => k.Id == id);
            if (kontakt != null)
            {
                return View(kontakt);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(Kontakt model)
        {
            if (ModelState.IsValid)
            {
                var kontakt = _kontakty.FirstOrDefault(k => k.Id == model.Id);
                if (kontakt != null)
                {
                    kontakt.Nazwa = model.Nazwa;
                    kontakt.Email = model.Email;
                    kontakt.Telefon = model.Telefon;
                    kontakt.Dataur = model.Dataur; 
                    kontakt.Priority = model.Priority; 
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var kontakt = _kontakty.FirstOrDefault(k => k.Id == id);
            if (kontakt != null)
            {
                return View(kontakt);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var kontakt = _kontakty.FirstOrDefault(k => k.Id == id);
            if (kontakt != null)
            {
                _kontakty.Remove(kontakt);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
