using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("product")]
public class Product
{
    [Key]
    public int ProductId { get; set; }

    public string Name { get; set; }

    [Column(TypeName = "text")]
    public string Description { get; set; }

    [Column(TypeName = "decimal(6,2)")]
    public decimal Price { get; set; }

    public List<Order> Ordered { get; set; }

    public Product(string name, string description, decimal price)
    {
        this.Name = name;
        this.Description = description;
        this.Price = price;
    }
}
