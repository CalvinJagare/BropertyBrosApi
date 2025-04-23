using Microsoft.AspNetCore.Identity;

namespace BropertyBrosApi2._0.Data
{
    public class ApiUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
