using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GimnasioApi.Models
{
    public class ClassAttendance
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid ClassScheduleId { get; set; }

        [ForeignKey("ClassScheduleId")]
        public ClassSchedule ClassSchedule { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public DateTime AttendanceDate { get; set; } = DateTime.Today;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
