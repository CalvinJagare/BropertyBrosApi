using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BropertyBrosApi.Models
{
    //Author: Calvin, Daniel, Emil
    public class Realtor
    {
        public int Id { get; set; }
        public int RealtorFirmId { get; set; }
        public string AppUserId { get; set; } = null!;

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProfileUrl { get; set; }

        public virtual List<Property> Properties { get; set; } = new List<Property>();
        public virtual RealtorFirm? RealtorFirm { get; set; }
        public virtual AppUser AppUser { get; set; } = null!;
    }
}
