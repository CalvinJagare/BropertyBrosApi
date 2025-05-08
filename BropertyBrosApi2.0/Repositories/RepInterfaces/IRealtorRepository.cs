using BropertyBrosApi.Models;
using BropertyBrosApi2._0.DTOs.Realtor;

namespace BropertyBrosApi2._0.Repositories.RepInterfaces
{
    //Author: Daniel
    public interface IRealtorRepository
    {
        Task<Realtor> GetByIdAsync(int id);
        Task<Realtor?> GetByUserIdAsync(string userId);
        Task<IEnumerable<Realtor>> GetAllAsync();
        Task Add(Realtor realtor);
        Task Update(Realtor realtor);
        Task Delete(Realtor realtor);
        Task<IEnumerable<Realtor>> GetBySearchAsync(RealtorSearchDto realtorSearchDto);
    }
}
