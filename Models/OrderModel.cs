using System.ComponentModel.DataAnnotations;

public class Order
{
    public Order(){ OrderItems = new List<OrderItem>(); }
    public int OrderId { get; set; }
    
    public int UserId { get; set; }
    public User? User { get; set; }
    
    public DateTime OrderDate { get; set; }
    
    public ICollection<OrderItem> OrderItems { get; set; }
}
