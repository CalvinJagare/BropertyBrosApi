using BropertyBrosApi.Data;
using BropertyBrosApi.Models;
using BropertyBrosApi2._0.DTOs.Realtor;
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

        // Author: Emil
        public async Task<IEnumerable<Realtor>> GetBySearchAsync(RealtorSearchDto realtorSearchDto)
        {
            IQueryable<Realtor> realtorsQuery = applicationDbContext.Realtors;

            if (realtorSearchDto.FirstName != null)
            {
                realtorsQuery = realtorsQuery
                    .Where(x => x.FirstName.Contains(realtorSearchDto.FirstName));
            }
            if (realtorSearchDto.LastName != null)
            {
                realtorsQuery = realtorsQuery
                    .Where(x => x.LastName.Contains(realtorSearchDto.LastName));
            }
            if (realtorSearchDto.RealtorFirmId.HasValue)
            {
                realtorsQuery = realtorsQuery
                    .Where(x => x.RealtorFirmId == realtorSearchDto.RealtorFirmId.Value);
            }

            return await realtorsQuery
                .Include(r => r.Properties)
                .ToListAsync();
        }

        public async Task<Realtor?> GetByUserIdAsync(string userId)
        {
            return await applicationDbContext.Realtors
                .FirstOrDefaultAsync(x => x.UserId == userId);
        }
    }
}
