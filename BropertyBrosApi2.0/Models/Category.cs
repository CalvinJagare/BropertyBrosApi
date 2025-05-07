using System.ComponentModel.DataAnnotations;

namespace BropertyBrosApi.Models
{
    //Author: Calvin, Daniel, Emil    
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string? CategoryName { get; set; }
    }
}
