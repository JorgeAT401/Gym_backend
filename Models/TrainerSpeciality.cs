using System.ComponentModel.DataAnnotations.Schema;

namespace GimnasioApi.Models
{
    public class TrainerSpeciality
    {
        public Guid TrainerId { get; set; }
        public Trainer Trainer { get; set; }

        public Guid SpecialityId { get; set; }
        public Speciality Speciality { get; set; }
    }
}
