using BropertyBrosApi.Models;

namespace BropertyBrosApi2._0.Repositories.RepInterfaces
{
    public interface IPropertyRepository
    {
        Task<Property> GetByIdAsync(int id);
        Task<IEnumerable<Property>> GetAllAsync();
        Task Add(Property property);
        Task Update(Property property);
        Task Delete(Property property);
    }
}
