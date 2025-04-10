using BropertyBrosApi.Data;
using BropertyBrosApi.Models;
using BropertyBrosApi2._0.Repositories.RepInterfaces;
using Microsoft.EntityFrameworkCore;

namespace BropertyBrosApi2._0.Repositories
{
    public class CityRepository : ICityRepository
    {
        //Author: Daniel
        private readonly ApplicationDbContext applicationDbContext;

        public CityRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task Add(City city)
        {
            await applicationDbContext.AddAsync(city);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task Delete(City city)
        {
            applicationDbContext.Remove(city);
            await applicationDbContext.SaveChangesAsync();
        }
        public async Task Update(City city)
        {
            applicationDbContext.Update(city);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<City>> GetAllAsync()
        {
            return await applicationDbContext.Cities.ToListAsync();
        }

        public async Task<City> GetByIdAsync(int id)
        {
            return await applicationDbContext.Cities.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
