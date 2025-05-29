using System.ComponentModel.DataAnnotations;

namespace GimnasioApi.Models
{
    public class User
    {
        /// <summary>
        /// The id of the user
        /// </summary>
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// The email of the user account which is required
        /// </summary>

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        /// <summary>
        /// The Username of the user account
        /// </summary>

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }
        /// <summary>
        /// The hashed password of the user account
        /// </summary>

        [Required]
        [MaxLength(100)]
        public string PasswordHash { get; set; }
        /// <summary>
        /// The timestamp of the creation of the account
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// The one to one relation of the user profile to an user account
        /// </summary>
        public UserProfile UserProfile { get; set; }
    }
}
