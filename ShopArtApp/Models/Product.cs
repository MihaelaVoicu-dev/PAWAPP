using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopArtApp.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public string? Description { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }

        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public int CommandDetailId { get; set; }
        public CommandDetail CommandDetail { get; set; }

    }
}
