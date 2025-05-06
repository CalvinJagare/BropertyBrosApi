using BropertyBrosApi.Models;

namespace BropertyBrosApi2._0.Repositories.RepInterfaces
{
    //Author: Daniel
    //Co-Author: Arlind
    public interface ICityRepository
    {
        Task<City> GetByIdAsync(int id);
        Task<IEnumerable<City>> GetAllAsync();
        Task Add(City city);
        Task Update(City city);
        Task Delete(City city);
    }
}
