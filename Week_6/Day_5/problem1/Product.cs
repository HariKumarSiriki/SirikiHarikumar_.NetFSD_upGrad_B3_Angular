using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [StringLength(15, MinimumLength = 5)]
        public string Category { get; set; }

    }
}
