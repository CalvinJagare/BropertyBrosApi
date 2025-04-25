using System.ComponentModel.DataAnnotations;

namespace BropertyBrosApi2._0.DTOs.Auth
{
    public class UserDto : LoginUserDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required] 
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
