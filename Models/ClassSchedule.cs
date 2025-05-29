using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GimnasioApi.Models
{
    public class ClassSchedule
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid ClassGroupId { get; set; }

        [ForeignKey("ClassGroupId")]
        public ClassGroup ClassGroup { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ICollection<ClassAttendance> ClassAttendances { get; set; }
    }
}
