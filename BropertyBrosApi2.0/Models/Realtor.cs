using BropertyBrosApi2._0.Data;
﻿using System.ComponentModel.DataAnnotations;

namespace BropertyBrosApi.Models
{
    //Author: Calvin, Daniel, Emil
    public class Realtor
    {
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? ProfileUrl { get; set; }
        public virtual List<Property> Properties { get; set; } = new List<Property>();

        public virtual RealtorFirm? RealtorFirm { get; set; }
        public int RealtorFirmId { get; set; }
        public virtual ApiUser User { get; set; } = null!;
        public string UserId { get; set; } = null!;
    }
}
