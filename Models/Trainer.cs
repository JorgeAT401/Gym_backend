using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GimnasioApi.Models
{
    public class Trainer
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public string Bio { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ICollection<TrainerSpeciality> TrainerSpecialities { get; set; }
        public ICollection<ClassGroup> ClassGroups { get; set; }
    }
}
