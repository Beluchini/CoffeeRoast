using CoffeeRoast.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeRoast.Database;

public class CoffeeContext : DbContext
{
    public DbSet<Coffee> Coffees { get; set; }
    public DbSet<CoffeeInfo> CoffeeInfos { get; set; }
    public DbSet<Basket> Baskets { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Accessory> Accessories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderHistory> OrderHistories { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=CoffeeRoast.db");
    }
}