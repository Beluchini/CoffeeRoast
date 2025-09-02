using System.ComponentModel.DataAnnotations;

namespace CoffeeRoast.Models;

public class CoffeeInfo
{
    [Key] public int Id { get; set; }
    public string CoffeDegRoast { get; set; }
    public string CoffeeRegion { get; set; }
    public string CofeeType { get; set; }
}