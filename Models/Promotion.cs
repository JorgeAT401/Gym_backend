using System.ComponentModel.DataAnnotations;

public class Promotion
{
    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? DiscountPercent { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public bool AppliesToAllProducts { get; set; }
}
