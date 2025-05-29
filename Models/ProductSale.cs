using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GimnasioApi.Models
{
    public class ProductSale
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public Guid? PaymentId { get; set; }

        [ForeignKey("PaymentId")]
        public Payment Payment { get; set; }

        [Range(1, 999)]
        public int Quantity { get; set; }

        public DateTime SaleDate { get; set; } = DateTime.UtcNow;

        public Guid? PromotionId { get; set; }

        [ForeignKey("PromotionId")]
        public Promotion Promotion { get; set; }

    }
}
