namespace BropertyBrosApi.Models
{
    //Author: Calvin, Daniel, Emil
    //Co-Author: Arlind
    public class RealtorFirm
    {
        public int Id { get; set; }
        public string? CompanyName { get; set; }
        public string? Description { get; set; }
        public string? LogoUrl { get; set; }
        public string? WebsiteUrl { get; set; }
        public virtual List<Realtor> Realtors { get; set; } = new List<Realtor>();
    }
}
