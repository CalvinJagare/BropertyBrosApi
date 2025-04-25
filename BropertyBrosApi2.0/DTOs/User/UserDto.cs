using System.ComponentModel.DataAnnotations;

namespace BropertyBrosApi2._0.DTOs.User
{
    public class UserDto : LoginUserDto
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
    }
}