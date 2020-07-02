using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using System.Linq;

namespace SCManager.Services
{
    public class SearchService : ISearchService
    {
        private readonly IUserComponentTypeService _userComponentTypeService;
        private readonly IComponentTypeService _componentTypeService;

        public SearchService(IUserComponentTypeService userComponentTypeService,
            IComponentTypeService componentTypeService)
        {
            _userComponentTypeService = userComponentTypeService;
            _componentTypeService = componentTypeService;
        }

        public IQueryable<UserComponentType> GetUserComponentTypes(string userId)
        {
            return _userComponentTypeService
                .GetAllForUserId(userId);
        }

        public IQueryable<ComponentType> GetAllComponentTypes()
        {
            return _componentTypeService
                .GetAll();
        }
    }
}