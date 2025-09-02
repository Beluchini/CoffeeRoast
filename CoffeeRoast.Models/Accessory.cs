using System.ComponentModel.DataAnnotations;

namespace CoffeeRoast.Models;

public class Accessory
{
    [Key] public int Id { get; set; }
    public string Tittle { get; set; }
    public string Description { get; set; }
    public string PhotoLink { get; set; }
    public string Type { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }
}