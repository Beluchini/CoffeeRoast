using System.ComponentModel.DataAnnotations;

namespace CoffeeRoast.Models;

public class User
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }
    public string MiddleName { get; set; }
    public string LasrName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}