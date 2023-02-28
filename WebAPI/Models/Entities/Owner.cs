namespace WebAPI.Models.Entities;

public class Owner
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(20)]
    [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
    public string Username { get; set; }
    
    [Required]
    public string Password { get; set; }
    
    [Required]
    [StringLength(5)]
    public string Name { get; set; }

    [MaxLength(3)]
    public ICollection<Shop> Shops { get; set; }
}