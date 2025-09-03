using CoffeeRoast.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeRoast.Database;

public class CoffeeContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Basket> Baskets { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=CoffeeRoast.db");
    }
}