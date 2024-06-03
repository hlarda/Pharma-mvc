using System.ComponentModel.DataAnnotations;

public class Category
{
    public Category(){ Products = new List<Product>(); }
    public int CategoryId { get; set; }
    
    [Required]
    [StringLength(100)]
    public string? Name { get; set; }
    
    public ICollection<Product> Products { get; set; }
}
