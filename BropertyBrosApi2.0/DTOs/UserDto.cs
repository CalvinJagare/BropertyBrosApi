using System.ComponentModel.DataAnnotations;

namespace BropertyBrosApi2._0.DTOs
{
    public class UserDto : LoginUserDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}