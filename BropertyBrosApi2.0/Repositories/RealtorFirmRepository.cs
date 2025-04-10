using BropertyBrosApi.Data;
using BropertyBrosApi.Models;
using BropertyBrosApi2._0.Repositories.RepInterfaces;
using Microsoft.EntityFrameworkCore;

namespace BropertyBrosApi2._0.Repositories
{
    //Author: Daniel
    public class RealtorFirmRepository : IRealtorFirmRepository
    {

        private readonly ApplicationDbContext applicationDbContext;

        public RealtorFirmRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task Add(RealtorFirm realtorFirm)
        {
            await applicationDbContext.AddAsync(realtorFirm);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task Delete(RealtorFirm realtorFirm)
        {
            applicationDbContext.Remove(realtorFirm);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task Update(RealtorFirm realtorFirm)
        {
            applicationDbContext.Update(realtorFirm);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<RealtorFirm>> GetAllAsync()
        {
            return await applicationDbContext.RealtorFirms.ToListAsync();
        }

        public async Task<RealtorFirm> GetByIdAsync(int id)
        {
            return await applicationDbContext.RealtorFirms
                .Include(r => r.Realtors)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
