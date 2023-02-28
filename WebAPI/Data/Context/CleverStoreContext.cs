using Microsoft.EntityFrameworkCore;
using WebAPI.Models.Entities;

namespace WebAPI.Data.Context;

public class CleverStoreContext : DbContext
{
    public CleverStoreContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Shop> Shops { get; set; }
}