using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("course")]
public class Order
{
    [Key]
    public int OrderId { get; set; }

    public DateTime Date { get; set; }

    [Column(TypeName = "decimal(6,2)")]
    public decimal Amount { get; set; }

    public string Status { get; set; }

    public int CustomerId { get; set; }

    public Customer Customer { get; set; }

    public List<Product> Products { get; set; }
}