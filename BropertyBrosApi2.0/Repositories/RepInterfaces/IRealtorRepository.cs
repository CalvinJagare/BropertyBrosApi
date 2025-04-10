using BropertyBrosApi.Models;

namespace BropertyBrosApi2._0.Repositories.RepInterfaces
{
    //Author: Daniel
    public interface IRealtorRepository
    {
        Task<Realtor> GetByIdAsync(int id);
        Task<IEnumerable<Realtor>> GetAllAsync();
        Task Add(Realtor realtor);
        Task Update(Realtor realtor);
        Task Delete(Realtor realtor);
    }
}
