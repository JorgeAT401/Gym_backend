using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GimnasioApi.Models
{
    public class MembershipAdjustment
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid UserMembershipId { get; set; }

        [ForeignKey("UserMembershipId")]
        public UserMembership UserMembership { get; set; }

        /// <summary>
        /// Número de días a ajustar. Puede ser positivo o negativo.
        /// </summary>
        [Range(-365, 365)]
        public int AdjustmentDays { get; set; }

        public string Reason { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
