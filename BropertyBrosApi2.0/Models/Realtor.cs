using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BropertyBrosApi.Models
{
    //Author: Calvin, Daniel, Emil
    public class Realtor : IdentityUser
    {
        public int RealtorFirmId { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string ProfileUrl { get; set; } = null!;

        public virtual List<Property>? Properties { get; set; } = null;
        public virtual RealtorFirm RealtorFirm { get; set; } = null!;
    }
}
