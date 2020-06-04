using AutoMapper;
using SCManager.Data.Models;
using SCManager.ViewModels.Admin;

namespace SCManager
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>();
        }
    }
}