using BropertyBrosApi.Data;
using BropertyBrosApi.Models;
using BropertyBrosApi2._0.DTOs.Properties;
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

        // Author: Emil
        public async Task<IEnumerable<Property>> GetAllByRealtorAsync(int realtorId)
        {
            return await applicationDbContext.Properties
                .Include(x => x.City)
                .Include(x => x.Category)
                .Where(x => x.RealtorId == realtorId)
                .ToListAsync();
        }

        // Author: Emil
        public async Task<IEnumerable<Property>> GetBySearchAsync(PropertySearchDto propertySearchDto)
        {
            IQueryable<Property> propertiesQuery = applicationDbContext.Properties;

            if (propertySearchDto.MaxPrice.HasValue)
            {
                propertiesQuery = propertiesQuery
                    .Where(x => x.Price <= propertySearchDto.MaxPrice && x.Price >= propertySearchDto.MinPrice);
            }
            if (propertySearchDto.MaxMonthlyFee.HasValue)
            {
                propertiesQuery = propertiesQuery
                    .Where(x => x.MonthlyFee <= propertySearchDto.MaxMonthlyFee && x.MonthlyFee >= propertySearchDto.MinMonthlyFee);
            }
            if (propertySearchDto.MaxYearlyFee.HasValue)
            {
                propertiesQuery = propertiesQuery
                    .Where(x => x.YearlyFee <= propertySearchDto.MaxYearlyFee && x.YearlyFee >= propertySearchDto.MinYearlyFee);
            }
            if (propertySearchDto.MaxLivingAreaKvm.HasValue)
            {
                propertiesQuery = propertiesQuery
                    .Where(x => x.LivingAreaKvm <= propertySearchDto.MaxLivingAreaKvm && x.LivingAreaKvm >= propertySearchDto.MinLivingAreaKvm);
            }
            if (propertySearchDto.MaxAncillaryAreaKvm.HasValue)
            {
                propertiesQuery = propertiesQuery
                    .Where(x => x.AncillaryAreaKvm <= propertySearchDto.MaxAncillaryAreaKvm && x.AncillaryAreaKvm >= propertySearchDto.MinAncillaryAreaKvm);
            }
            if (propertySearchDto.MaxLandAreaKvm.HasValue)
            {
                propertiesQuery = propertiesQuery
                    .Where(x => x.LandAreaKvm <= propertySearchDto.MaxLandAreaKvm && x.LandAreaKvm >= propertySearchDto.MinLandAreaKvm);
            }
            if (propertySearchDto.MaxNumberOfRooms.HasValue)
            {
                propertiesQuery = propertiesQuery
                    .Where(x => x.NumberOfRooms <= propertySearchDto.MaxNumberOfRooms && x.NumberOfRooms >= propertySearchDto.MinNumberOfRooms);
            }
            if (propertySearchDto.MaxBuildYear.HasValue)
            {
                propertiesQuery = propertiesQuery
                    .Where(x => x.BuildYear <= propertySearchDto.MaxBuildYear && x.BuildYear >= propertySearchDto.MinBuildYear);
            }
            if (propertySearchDto.CategoryId.HasValue)
            {
                propertiesQuery = propertiesQuery
                    .Where(x => x.CategoryId == propertySearchDto.CategoryId);
            }
            if (propertySearchDto.CityId.HasValue)
            {
                propertiesQuery = propertiesQuery
                    .Where(x => x.CityId == propertySearchDto.CityId);
            }

            return await propertiesQuery
                .Include(x => x.Category)
                .Include(x => x.City)
                .Include(x => x.Realtor)
                .ToListAsync();
        }
    }
}
