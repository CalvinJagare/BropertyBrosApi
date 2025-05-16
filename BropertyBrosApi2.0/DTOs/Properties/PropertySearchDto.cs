namespace BropertyBrosApi2._0.DTOs.Properties
{
    public class PropertySearchDto
    {
        public string? Address { get; set; } = null;
        public int MinPrice { get; set; }
        public int? MaxPrice { get; set; } = null;
        public int MinMonthlyFee { get; set; }
        public int? MaxMonthlyFee { get; set; } = null;
        public int MinYearlyFee { get; set; }
        public int? MaxYearlyFee { get; set; } = null;
        public int MinLivingAreaKvm { get; set; }
        public int? MaxLivingAreaKvm { get; set; } = null;
        public int MinAncillaryAreaKvm { get; set; }
        public int? MaxAncillaryAreaKvm { get; set; } = null;
        public int MinLandAreaKvm { get; set; }
        public int? MaxLandAreaKvm { get; set; } = null;
        public int MinNumberOfRooms { get; set; }
        public int? MaxNumberOfRooms { get; set; } = null;
        public int MinBuildYear { get; set; }
        public int? MaxBuildYear { get; set; } = null;
        public int? CityId { get; set; } = null;
        public int? CategoryId { get; set; } = null;
    }
}
