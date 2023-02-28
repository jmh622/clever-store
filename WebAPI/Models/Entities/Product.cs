namespace WebAPI.Models.Entities;

public class Product
{
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    [MaxLength(5)] 
    public ICollection<Category> Categories { get; set; }
    
    [Range(typeof(int), "1000", "10000000")]
    public int Price { get; set; }
    
    [Required]
    public string Image { get; set; }
}