using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("customer")]
public class Customer
{
    [Key]
    public int CustomerId { get; set; }

    [Required]
    public string Name { get; set; }

    public string Surname { get; set; }

    [Column("customer_email")]
    public string Email { get; set; }

    public Customer(string name, string surname, string email)
    {
        this.Name = name;
        this.Surname = surname;
        this.Email = email;
    }
}