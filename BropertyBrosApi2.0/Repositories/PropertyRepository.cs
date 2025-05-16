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

            // Price
            propertiesQuery = propertiesQuery.Where(x => x.Price >= propertySearchDto.MinPrice);
            if (propertySearchDto.MaxPrice.HasValue)
                propertiesQuery = propertiesQuery.Where(x => x.Price <= propertySearchDto.MaxPrice.Value);

            // Monthly fee
            propertiesQuery = propertiesQuery.Where(x => x.MonthlyFee >= propertySearchDto.MinMonthlyFee);
            if (propertySearchDto.MaxMonthlyFee.HasValue)
                propertiesQuery = propertiesQuery.Where(x => x.MonthlyFee <= propertySearchDto.MaxMonthlyFee.Value);

            // Yearly fee
            propertiesQuery = propertiesQuery.Where(x => x.YearlyFee >= propertySearchDto.MinYearlyFee);
            if (propertySearchDto.MaxYearlyFee.HasValue)
                propertiesQuery = propertiesQuery.Where(x => x.YearlyFee <= propertySearchDto.MaxYearlyFee.Value);

            // Living area
            propertiesQuery = propertiesQuery.Where(x => x.LivingAreaKvm >= propertySearchDto.MinLivingAreaKvm);
            if (propertySearchDto.MaxLivingAreaKvm.HasValue)
                propertiesQuery = propertiesQuery.Where(x => x.LivingAreaKvm <= propertySearchDto.MaxLivingAreaKvm.Value);

            // Ancillary area
            propertiesQuery = propertiesQuery.Where(x => x.AncillaryAreaKvm >= propertySearchDto.MinAncillaryAreaKvm);
            if (propertySearchDto.MaxAncillaryAreaKvm.HasValue)
                propertiesQuery = propertiesQuery.Where(x => x.AncillaryAreaKvm <= propertySearchDto.MaxAncillaryAreaKvm.Value);

            // Land area
            propertiesQuery = propertiesQuery.Where(x => x.LandAreaKvm >= propertySearchDto.MinLandAreaKvm);
            if (propertySearchDto.MaxLandAreaKvm.HasValue)
                propertiesQuery = propertiesQuery.Where(x => x.LandAreaKvm <= propertySearchDto.MaxLandAreaKvm.Value);

            // Number of rooms
            propertiesQuery = propertiesQuery.Where(x => x.NumberOfRooms >= propertySearchDto.MinNumberOfRooms);
            if (propertySearchDto.MaxNumberOfRooms.HasValue)
                propertiesQuery = propertiesQuery.Where(x => x.NumberOfRooms <= propertySearchDto.MaxNumberOfRooms.Value);

            // Build year
            propertiesQuery = propertiesQuery.Where(x => x.BuildYear >= propertySearchDto.MinBuildYear);
            if (propertySearchDto.MaxBuildYear.HasValue)
                propertiesQuery = propertiesQuery.Where(x => x.BuildYear <= propertySearchDto.MaxBuildYear.Value);

            // Category
            if (propertySearchDto.CategoryId.HasValue)
            {
                propertiesQuery = propertiesQuery
                    .Where(x => x.CategoryId == propertySearchDto.CategoryId);
            }

            // City
            if (propertySearchDto.CityId.HasValue)
            {
                propertiesQuery = propertiesQuery
                    .Where(x => x.CityId == propertySearchDto.CityId);
            }

            // Address
            if (!string.IsNullOrEmpty(propertySearchDto.Address))
            {
                propertiesQuery = propertiesQuery
                    .Where(x => x.Address!.Contains(propertySearchDto.Address));
            }

            return await propertiesQuery
                .Include(x => x.Category)
                .Include(x => x.City)
                .Include(x => x.Realtor)
                .ToListAsync();
        }
    }
}
