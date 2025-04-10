using BropertyBrosApi.Models;

namespace BropertyBrosApi2._0.Repositories.RepInterfaces
{
    //Author: Daniel
    public interface ICategoryRepository
    {
        Task<Category> GetByIdAsync(int id);
        Task<IEnumerable<Category>> GetAllAsync();
        Task Add(Category category);
        Task Update(Category category);
        Task Delete(Category category);
    }
}
