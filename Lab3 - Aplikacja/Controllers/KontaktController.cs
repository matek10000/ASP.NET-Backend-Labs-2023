using Lab3___Aplikacja.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Sqlite;
using Data;
using Data.Entities;

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
            var kontakty = _contactService.FindAll();
            return View(kontakty);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Kontakt model = new Kontakt();
            model.Organizations = _contactService
                .FindAllOrganizations()
                .Select(oe => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem()
                {
                    Text = oe.Name,
                    Value = oe.Id.ToString(),

                }
                ).ToList();
            return View(model);
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
            var kontakt = _contactService.FindById(id);

            kontakt.Organizations = _contactService
                .FindAllOrganizations()
                .Select(oe => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem()
                {
                    Text = oe.Name,
                    Value = oe.Id.ToString(),

                }
                ).ToList();

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
                _contactService.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }



        [HttpGet]
        public IActionResult Details(int id)
        {
            var kontakt = _contactService.FindById(id);
            if (kontakt != null)
            {
                return View(kontakt);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var kontakt = _contactService.FindById(id);
            if (kontakt != null)
            {
                _contactService.Delete(kontakt.Id);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}
