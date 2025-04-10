using BropertyBrosApi.Data;
using BropertyBrosApi.Models;
using BropertyBrosApi2._0.Repositories.RepInterfaces;
using Microsoft.EntityFrameworkCore;

namespace BropertyBrosApi2._0.Repositories
{
    //Author: Daniel
    public class CategoryRepository : ICategoryRepository
    {

        private readonly ApplicationDbContext applicationDbContext;

        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task Add(Category category)
        {
            await applicationDbContext.AddAsync(category);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task Delete(Category category)
        {
            applicationDbContext.Remove(category);
            await applicationDbContext.SaveChangesAsync();
        }
        public async Task Update(Category category)
        {
            applicationDbContext.Update(category);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await applicationDbContext.Categories.ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await applicationDbContext.Categories.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
