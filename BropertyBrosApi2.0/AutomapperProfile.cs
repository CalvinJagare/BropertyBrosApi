using AutoMapper;
using BropertyBrosApi.Models;
using BropertyBrosApi2._0.Data;
using BropertyBrosApi2._0.DTOs;
using BropertyBrosApi2._0.DTOs.Category;
using BropertyBrosApi2._0.DTOs.City;
using BropertyBrosApi2._0.DTOs.Properties;
using BropertyBrosApi2._0.DTOs.Realtor;
using BropertyBrosApi2._0.DTOs.RealtorFirm;

namespace BropertyBrosApi2._0
{
    //Author: Calvin, Daniel, Emil
    //Co-Author: Arlind
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<CategoryCreateDto, Category>();
            CreateMap<Category, CategoryReadDto>();       

            CreateMap<CityCreateDto, City>();
            CreateMap<City, CityReadDto>();

            CreateMap<PropertyCreateDto, Property>();
            CreateMap<Property, PropertyReadDto>()
                .ForMember(dest => dest.RealtorName, opt => opt.MapFrom(src => src.Realtor.FirstName + " " + src.Realtor.LastName))
                .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.City.CityName))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName));

            CreateMap<RealtorCreateDto, Realtor>();
            CreateMap<Realtor, RealtorReadDto>()
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.RealtorFirm.CompanyName))
                .ForMember(dest => dest.LogoUrl, opt => opt.MapFrom(src => src.RealtorFirm.LogoUrl))
                .ForMember(dest => dest.WebsiteUrl, opt => opt.MapFrom(src => src.RealtorFirm.WebsiteUrl));

            CreateMap<RealtorFirmCreateDto, RealtorFirm>();
            CreateMap<RealtorFirm, RealtorFirmReadDto>()
                .ForMember(dest => dest.Realtors, opt => opt.MapFrom(src => src.Realtors));

        }
    }   
}
