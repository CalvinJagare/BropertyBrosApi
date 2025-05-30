﻿namespace BropertyBrosApi2._0.DTOs.Realtor
{
    //Author: Calvin, Daniel, Emil
    //Co-Author: Arlind

    public class RealtorCreateDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? ProfileUrl { get; set; }
        public int RealtorFirmId { get; set; } 
    }
}
