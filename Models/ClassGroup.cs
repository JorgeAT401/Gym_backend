using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GimnasioApi.Models
{
    public class ClassGroup
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int Capacity { get; set; }

        // Nueva relación con Trainer
        public Guid? TrainerId { get; set; }
        [ForeignKey("TrainerId")]
        public Trainer Trainer { get; set; }

        public ICollection<ClassSchedule> ClassSchedules { get; set; }
        public ICollection<ClassAttendance> ClassAttendances { get; set; }
    }
}
