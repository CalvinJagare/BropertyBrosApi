using Microsoft.AspNetCore.Identity;

namespace BropertyBrosApi2._0.Models
{
    public class ApiUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
