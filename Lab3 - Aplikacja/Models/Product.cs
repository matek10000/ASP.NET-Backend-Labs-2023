using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lab3___Aplikacja.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Pole 'Nazwa' jest wymagane.")]
        public string Nazwa { get; set; }

        [Required(ErrorMessage = "Pole 'Cena' jest wymagane.")]
        [Range(0, double.MaxValue, ErrorMessage = "Cena musi być nieujemna.")]
        public decimal Cena { get; set; }

        [Required(ErrorMessage = "Pole 'Producent' jest wymagane.")]
        public string Producent { get; set; }

        [Display(Name = "Data Produkcji")]
        [DataType(DataType.Date)]
        public DateTime DataProdukcji { get; set; }

        [Display(Name = "Opis")]
        public string Opis { get; set; }
    }
}
