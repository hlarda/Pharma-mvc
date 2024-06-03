using System.ComponentModel.DataAnnotations;

public class User
{
    public int UserId { get; set; }
    
    [Required (ErrorMessage = "Please enter a username")]
    [StringLength(100)]
    public string? UserName { get; set; }
    
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    
    [Required]
    public string? PasswordHash { get; set; }
    
    // Additional properties
    public bool IsAdmin { get; set; }
}
