using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopArtApp.Models
{
    [Table("Commands")]
    public class Command
    {
        [Key]
        public int CommandId { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        public string? Status { get; set; } = string.Empty;
        [Required]
        public double Total { get; set; }
        [Required]
        public DateTime DateCommand { get; set; }
     
       
        public int idFind { get; set; }
        public int BillAddressId { get; set; }
        public BillAddress BillAddress { get; set; }    
    }
}