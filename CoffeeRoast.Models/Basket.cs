using System.ComponentModel.DataAnnotations;

namespace CoffeeRoast.Models;

public class Basket
{
    [Key] public int Id { get; set; }
    public string BasketTittle { get; set; }
    public string BasketPhotoLink { get; set; }
    public string BasketType { get; set; }
    public string? BasketDegreeOfRoast { get; set; }
    public string? BasketRegion { get; set; }
    public decimal BasketPrice { get; set; }
    public int BasketCount { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}