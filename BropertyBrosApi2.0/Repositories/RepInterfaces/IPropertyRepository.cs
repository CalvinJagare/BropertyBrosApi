using BropertyBrosApi.Models;
using BropertyBrosApi2._0.DTOs.Properties;

namespace BropertyBrosApi2._0.Repositories.RepInterfaces
{
    //Author: Daniel
    public interface IPropertyRepository
    {
        Task<Property> GetByIdAsync(int id);
        Task<IEnumerable<Property>> GetAllAsync();
        Task<IEnumerable<Property>> GetAllByRealtorAsync(int realtorId);
        Task<IEnumerable<Property>> GetBySearchAsync(PropertySearchDto propertySearchDto);
        Task Add(Property property);
        Task Update(Property property);
        Task Delete(Property property);
    }
}
