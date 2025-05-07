namespace BropertyBrosApi.Models
{
    //Author: Calvin, Daniel, Emil
    //Co-Author: Arlind
    public class Realtor
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? ProfileUrl { get; set; }
        public virtual List<Property> Properties { get; set; } = new List<Property>();

        public virtual RealtorFirm? RealtorFirm { get; set; }
        public int RealtorFirmId { get; set; } 
    }
}
