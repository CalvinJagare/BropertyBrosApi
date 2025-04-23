using BropertyBrosApi.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BropertyBrosApi.Models
{
    public class AppUser : IdentityUser
    {
        public virtual Realtor? Realtor { get; set; } = null;
    }
}
