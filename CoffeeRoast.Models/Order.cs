using System.ComponentModel.DataAnnotations;

namespace CoffeeRoast.Models;

public class Order
{
    [Key] public int Id { get; set; }
    public string Addres { get; set; }
    public string City { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime OrderTime { get; set; }
}