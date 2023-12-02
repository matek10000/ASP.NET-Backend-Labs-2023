using Projekt___produkty.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Sqlite;
using ProductData;
using ProductData.Entities;
using Microsoft.AspNetCore.Authorization;

namespace Projekt___produkty.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult PagedIndex(int? page = 1, int? size = 2)
        {
            return View(_productService.FindPage((int)page, (int)size));
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var products = _productService.FindAll();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Product model = new Product();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(model);
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
            var product = _productService.FindById(id);
            if (product != null)
            {
                return View(product);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(Product model)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var product = _productService.FindById(id);
            if (product != null)
            {
                return View(product);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = _productService.FindById(id);
            if (product != null)
            {
                _productService.Delete(product.Id);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
