using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3___Aplikacja.Models
{
    public class Kontakt
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Sprawdź poprawność imienia!")]
        [StringLength(maximumLength: 100, ErrorMessage = "Twoje imie jest za długie!")]
        public string Nazwa { get; set; }

        [Required(ErrorMessage = "Sprawdź poprawność E-maila!")]
        [EmailAddress]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Sprawdź poprawność numeru telefonu!")]
        public string Telefon { get; set; }

        public DateTime Dataur { get; set; }

    }
}
