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

        private readonly AppDbContext _contactService;

        public KontaktController(AppDbContext context)
        {
            _contactService = context;
        }

        public IActionResult Index()
        {
            var kontakty = _contactService.Contacts.ToList();
            return View(kontakty);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new ContactEntity());
        }

        [HttpPost]
        public IActionResult Create(ContactEntity model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Contacts.Add(model);
                _contactService.SaveChanges();
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
            var kontakt = _contactService.Contacts.FirstOrDefault(k => k.ContactId == id);
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
                var kontakt = _contactService.Contacts.FirstOrDefault(k => k.ContactId == model.Id);
                if (kontakt != null)
                {
                    kontakt.Name = model.Name;
                    kontakt.Email = model.Email;
                    kontakt.Phone = model.Phone;
                    kontakt.Birth = model.Birth;

                    _contactService.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }



        [HttpGet]
        public IActionResult Details(int id)
        {
            var kontakt = _contactService.Contacts.FirstOrDefault(k => k.ContactId == id);
            if (kontakt != null)
            {
                return View(kontakt);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var kontakt = _contactService.Contacts.FirstOrDefault(k => k.ContactId == id);
            if (kontakt != null)
            {
                _contactService.Contacts.Remove(kontakt);
                _contactService.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}
