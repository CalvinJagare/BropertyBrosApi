using System.ComponentModel.DataAnnotations;

namespace BropertyBrosApi2._0.DTOs.Auth
{
    public class LoginDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        [MinLength(6)]
        public string Password { get; set; } = null!;
    }
}
