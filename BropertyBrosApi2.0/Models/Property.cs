namespace BropertyBrosApi.Models
{
    //Author: Calvin, Daniel, Emil
    public class Property
    {
        public int Id { get; set; }
        public int RealtorId { get; set; }
        public int CityId { get; set; }
        public int CategoryId { get; set; }

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
        public List<string> ImageUrls { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

        public virtual Realtor Realtor { get; set; } = null!;
        public virtual City City { get; set; } = null!;
        public virtual Category Category { get; set; } = null!;
    }
}
