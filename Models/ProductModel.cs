using System.ComponentModel.DataAnnotations;

public class Product
{
    public int ProductId { get; set; }
    
    [Required]
    [StringLength(100)]
    public string? Name { get; set; }
    
    [Required]
    [StringLength(1000)]
    public string? Description { get; set; }
    
    [Range(0.01, 10000.00)]
    public decimal Price { get; set; }
    
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    
    public string? ImagePath { get; set; }  // File path of the product image
}
