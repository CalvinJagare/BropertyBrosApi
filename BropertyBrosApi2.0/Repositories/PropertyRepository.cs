using BropertyBrosApi.Data;
using BropertyBrosApi.Models;
using BropertyBrosApi2._0.Repositories.RepInterfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BropertyBrosApi2._0.Repositories
{
    //Author: Daniel
    public class PropertyRepository : IPropertyRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public PropertyRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task Add(Property property)
        {
            await applicationDbContext.AddAsync(property);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task Delete(Property property)
        {
            applicationDbContext.Remove(property);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task Update(Property property)
        {
            applicationDbContext.Update(property);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Property>> GetAllAsync()
        {
            return await applicationDbContext.Properties.ToListAsync();
        }

        public async Task<Property> GetByIdAsync(int id)
        {
            return await applicationDbContext.Properties
                .Include(p => p.Category)
                .Include(p => p.City)
                .Include(p => p.Realtor)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
