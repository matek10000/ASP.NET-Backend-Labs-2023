using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Projekt___produkty.Models
{
    public class Product
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Sprawdź poprawność nazwy produktu!")]
        [StringLength(maximumLength: 100, ErrorMessage = "Nazwa produktu jest za długa!")]
        [Display(Name = "Nazwa produktu:")]
        public string Name { get; set; }

        [Display(Name = "Cena:")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Sprawdź poprawność producenta!")]
        [Display(Name = "Producent:")]
        public string Manufacturer { get; set; }

        [Display(Name = "Data produkcji:")]
        [DataType(DataType.Date)]
        public DateTime ProductionDate { get; set; }

        [Required(ErrorMessage = "Sprawdź poprawność opisu produktu!")]
        [Display(Name = "Opis produktu:")]
        public string Description { get; set; }
    }
}
