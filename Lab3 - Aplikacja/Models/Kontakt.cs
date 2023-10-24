using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3___Aplikacja.Models
{

    public enum Priority
    {
        [Display(Name = "Niski")] Low = 1,
        [Display(Name = "Normalny")] Normal = 2,
        [Display(Name = "Wysoki")] High = 3,
        [Display(Name = "Pilny")] Urgent = 4
    }

    public class Kontakt
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Sprawdź poprawność imienia!")]
        [StringLength(maximumLength: 100, ErrorMessage = "Twoje imie jest za długie!")]
        [Display(Name = "Imię:")]
        public string Nazwa { get; set; }

        [Required(ErrorMessage = "Sprawdź poprawność E-maila!")]
        [EmailAddress]
        [Display(Name = "E-mail:")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Sprawdź poprawność numeru telefonu!")]
        [Display(Name = "Telefon:")]
        public string Telefon { get; set; }

        [Display(Name = "Data urodzenia:")]
        public DateTime Dataur { get; set; }

        [Display(Name = "Priorytet:")]
        public Priority Priority { get; set; }
    }
}
