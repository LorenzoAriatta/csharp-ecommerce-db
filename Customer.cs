using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("student")]
public class Customer
{
    [Key]
    public int CustomerId { get; set; }

    [Required]
    public string Name { get; set; }

    public string Surname { get; set; }

    [Column("customer_email")]
    public string Email { get; set; }
}