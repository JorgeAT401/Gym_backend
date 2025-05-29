using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GimnasioApi.Models
{
    public class UserProfile
    {
        /// <summary>
        /// The id of the user profile
        /// </summary>
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// The id of the related user
        /// </summary>
        [Required]
        public Guid UserId { get; set; }
        /// <summary>
        /// The related user row
        /// </summary>

        [ForeignKey("UserId")]
        public User User { get; set; }

        /// <summary>
        /// The name of the user
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The gender of the user
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// The birth date of the user
        /// </summary>
        public DateTime BirthDate { get; set; }
    }
}
