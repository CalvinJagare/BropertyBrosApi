namespace BropertyBrosApi.Models
{
    //Author: Calvin, Daniel, Emil
    public class Property
    {
        public int Id { get; set; }
        public string? Address { get; set; }
        public int Price { get; set; }
        public int MonthlyFee { get; set; }
        public int YearlyFee { get; set; }
        public int LivingAreaKvm { get; set; }
        public int AncillaryAreaKvm { get; set; } // garage, balkong, källare etc
        public int LandAreaKvm { get; set; }
        public string? Description { get; set; }
        public int NumberOfRooms { get; set; }
        public int BuildYear { get; set; }
        public virtual List<string> ImageUrls { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public virtual Realtor Realtor { get; set; }
        public int RealtorId { get; set; }
        public virtual City City { get; set; }
        public int CityId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
