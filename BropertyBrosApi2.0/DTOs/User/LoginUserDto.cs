using System.ComponentModel.DataAnnotations;

namespace BropertyBrosApi2._0.DTOs.User
{
    public class LoginUserDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}