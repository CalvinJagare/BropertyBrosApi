using BropertyBrosApi.Models;

namespace BropertyBrosApi2._0.Repositories.RepInterfaces
{
    //Author: Daniel
    public interface IRealtorFirmRepository
    {
        Task<RealtorFirm> GetByIdAsync(int id);
        Task<IEnumerable<RealtorFirm>> GetAllAsync();
        Task Add(RealtorFirm realtorFirm);
        Task Update(RealtorFirm realtorFirm);
        Task Delete(RealtorFirm realtorFirm);
    }
}
