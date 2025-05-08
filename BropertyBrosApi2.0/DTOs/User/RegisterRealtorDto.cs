using System.ComponentModel.DataAnnotations;

namespace BropertyBrosApi2._0.DTOs.User
{
    public class RegisterRealtorDto : LoginUserDto
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        public string? ProfileUrl { get; set; }
        [Required]
        public int RealtorFirmId { get; set; }
    }
}