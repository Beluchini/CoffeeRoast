using System.ComponentModel.DataAnnotations;

namespace CoffeeRoast.Models;

public class Order
{
    [Key] public int Id { get; set; }
    public string Addres { get; set; }
    public string OrderTittle { get; set; }
    public string OrderPhotoLink { get; set; }
    public string OrderType { get; set; }
    public string? OrderDegreeOfRoast { get; set; }
    public string? OrderRegion { get; set; }
    public decimal OrderPrice { get; set; }
    public int OrderCount { get; set; }
    public DateTime OrderDate { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
}