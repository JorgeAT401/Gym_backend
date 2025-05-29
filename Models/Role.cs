using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GimnasioApi.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Role
    {
        /// <summary>
        /// The id of the role
        /// </summary>
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// The name of the role, must be unique
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// The description of the role
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The creation date of the user account
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
