using AutoMapper;
using SCManager.Data.Models;
using SCManager.InputModels;
using SCManager.ViewModels.Admin;

namespace SCManager
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>();
            CreateMap<ComponentType, ComponentTypeViewModel>();
            CreateMap<UnitMultiplier, UnitMultiplierViewModel>();
            CreateMap<StaticSiteInfo, StaticSiteInfoViewModel>();

            CreateMap<ComponentType, ComponentTypeInputModel>();
            CreateMap<UnitMultiplier, UnitMultiplierInputModel>();
            CreateMap<StaticSiteInfo, StaticSiteInfoInputModel>();
        }
    }
}