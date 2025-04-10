using BropertyBrosApi.Data;
using BropertyBrosApi.Models;
using BropertyBrosApi2._0.Repositories.RepInterfaces;
using Microsoft.EntityFrameworkCore;

namespace BropertyBrosApi2._0.Repositories
{
    //Author: Daniel
    public class RealtorRepository : IRealtorRepository
    {

        private readonly ApplicationDbContext applicationDbContext;

        public RealtorRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task Add(Realtor realtor)
        {
            await applicationDbContext.AddAsync(realtor);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task Delete(Realtor realtor)
        {
            applicationDbContext.Remove(realtor);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task Update(Realtor realtor)
        {
            applicationDbContext.Update(realtor);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Realtor>> GetAllAsync()
        {
            return await applicationDbContext.Realtors.ToListAsync();
        }

        public async Task<Realtor> GetByIdAsync(int id)
        {
            return await applicationDbContext.Realtors
                .Include(r => r.RealtorFirm)
                .Include(r => r.Properties)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
