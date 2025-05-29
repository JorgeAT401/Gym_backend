using System.ComponentModel.DataAnnotations;

public class ProductCategory
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    public string Description { get; set; }

    public bool IsActive { get; set; } = true;
}
