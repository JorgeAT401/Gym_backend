using System.ComponentModel.DataAnnotations;

namespace GimnasioApi.Models
{
    public class Speciality
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<TrainerSpeciality> TrainerSpecialities { get; set; }
    }
}
