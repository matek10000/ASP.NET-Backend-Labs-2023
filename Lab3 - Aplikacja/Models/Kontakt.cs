using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Lab3___Aplikacja.Models
{
    public class Kontakt
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Sprawdź poprawność imienia!")]
        [StringLength(maximumLength: 100, ErrorMessage = "Twoje imie jest za długie!")]
        [Display(Name = "Imię:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Sprawdź poprawność E-maila!")]
        [Display(Name = "E-mail:")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Sprawdź poprawność numeru telefonu!")]
        [Display(Name = "Telefon:")]
        public string Phone { get; set; }

        [Display(Name = "Data urodzenia:")]
        public DateTime Birth { get; set; }

        public int? OrganizationId { get; set; }

        [ValidateNever]
        public List<SelectListItem> Organizations { get; set; }
    }
}
