using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductData.Entities
{
    [Table("products")]
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Sprawdź poprawność nazwy produktu!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Sprawdź poprawność producenta!")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "Sprawdź poprawność opisu produktu!")]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime ProductionDate { get; set; }
    }
}
