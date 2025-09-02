using System.ComponentModel.DataAnnotations;

namespace CoffeeRoast.Models;

public class Coffee
{
    [Key] public int Id { get; set; }
    public string Tittle { get; set; }
    public string PhotoLink { get; set; }
    public string Type { get; set; }
    public string DegreeOfRoast { get; set; }
    public string Region { get; set; }
    public decimal Price { get; set; }
    public int Weight { get; set; }
    
}