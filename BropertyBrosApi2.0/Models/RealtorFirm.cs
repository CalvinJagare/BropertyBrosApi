using System.ComponentModel.DataAnnotations;

namespace BropertyBrosApi.Models
{
    //Author: Calvin, Daniel, Emil
    public class RealtorFirm
    {
        public int Id { get; set; }
        [Required]
        public string? CompanyName { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? LogoUrl { get; set; }
        [Required]
        public string? WebsiteUrl { get; set; }
        public virtual List<Realtor> Realtors { get; set; } = new List<Realtor>();
    }
}
