using SCManager.Data.Models;
using System.Linq;

namespace SCManager.Data.Interfaces
{
    public interface ISearchService
    {
        IQueryable<UserComponentType> GetUserComponentTypes(string userId);

        IQueryable<ComponentType> GetAllComponentTypes();
    }
}