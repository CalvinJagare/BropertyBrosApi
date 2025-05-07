using System.ComponentModel.DataAnnotations;

namespace BropertyBrosApi.Models
{
    //Author: Calvin, Daniel, Emil
    public class Property
    {
        public int Id { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int MonthlyFee { get; set; }
        [Required]
        public int YearlyFee { get; set; }
        [Required]
        public int LivingAreaKvm { get; set; }
        [Required]
        public int AncillaryAreaKvm { get; set; } // garage, balkong, källare etc
        [Required]
        public int LandAreaKvm { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public int NumberOfRooms { get; set; }
        [Required]
        public int BuildYear { get; set; }
        [Required]
        public List<string> ImageUrls { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public virtual Realtor? Realtor { get; set; }
        public int RealtorId { get; set; }
        public virtual City? City { get; set; }
        public int CityId { get; set; }
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
    }
}
