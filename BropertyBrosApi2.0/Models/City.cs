using System.ComponentModel.DataAnnotations;

namespace BropertyBrosApi.Models
{
    //Author: Calvin, Daniel, Emil
    public class City
    {
        public int Id { get; set; }
        [Required]
        public string? CityName { get; set; }
    }
}
