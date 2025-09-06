using System.ComponentModel.DataAnnotations;

namespace CoffeeRoast.Models;

public class User
{
    [Key] 
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Имя обязательно")]
    public string Name { get; set; }
    
    public string MiddleName { get; set; }
    
    [Required(ErrorMessage = "Фамилия обязательна")]
    public string LastName { get; set; }
    
    [Required(ErrorMessage = "Пароль обязателен")]
    [MinLength(8, ErrorMessage = "Пароль должен содержать минимум 8 символов")]
    public string Password { get; set; }
    
    [Required(ErrorMessage = "Email обязателен")]
    [EmailAddress(ErrorMessage = "Некорректный формат email")]
    public string Email { get; set; }
    
    [Phone(ErrorMessage = "Некорректный формат телефона")]
    public string PhoneNumber { get; set; }
}