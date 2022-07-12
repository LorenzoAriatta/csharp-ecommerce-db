using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("course_image")]
public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Column(TypeName = "text")]
    public string Description { get; set; }

    [Column(TypeName = "decimal(6,2)")]
    public decimal Price { get; set; }

    List<Order> Orders { get; set; }
}
