using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCManager.Data.Interfaces;
using SCManager.Services;
using SCManager.Tests.Services;

namespace SCManager.Tests
{
    [TestClass]
    public class SearchServiceTests : BaseTest
    {
        private ISearchService _searchService;
        private IUserComponentTypeService _userComponentTypeService;
        private IComponentTypeService _componentTypeService;

        public SearchServiceTests()
        {
            _userComponentTypeService = new UserComponentTypeService(SCManagerDbContext);
            _componentTypeService = new ComponentTypeService(SCManagerDbContext);

            _searchService = new SearchService(_userComponentTypeService, _componentTypeService);
        }

        [TestMethod]
        public void GetUserComponentTypes_WhenCalled_ShouldNotReturnNull()
        {
            // TEMP METHOD - IQueryable never returns null!
            // Until i figure out what exactly to test here

            var result = _searchService.GetUserComponentTypes("");

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetAllComponentTypes_WhenCalled_ShouldNotReturnNull()
        {
            // TEMP METHOD - IQueryable never returns null!
            // Until i figure out what exactly to test here

            var result = _searchService.GetAllComponentTypes();

            Assert.IsNotNull(result);
        }
    }
}