using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.Services;
using System.Threading.Tasks;

namespace SCManager.Tests.Services
{
    [TestClass]
    public class ComponentTypeServiceTests : BaseTest
    {
        private readonly IComponentTypeService _componentTypeService;

        public ComponentTypeServiceTests()
        {
            _componentTypeService = new ComponentTypeService(SCManagerDbContext);
        }

        [TestMethod]
        public void GetAll_WhenCalled_ShouldntReturnNull()
        {
            var result = _componentTypeService.GetAll();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetByIdAsync_WhenIdIsNull_ShouldReturnNull()
        {
            var result = await _componentTypeService.GetByIdAsync(null);
            Assert.IsNull(result);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(-2)]
        public async Task GetByIdAsync_WhenIdIsInvalid_ShouldReturnNull(int value)
        {
            var result = await _componentTypeService.GetByIdAsync(value);
            Assert.IsNull(result);
        }

        [TestMethod]
        public async Task SaveChangesAsync_WhenArgumentIsNull_ShouldReturnNewObject()
        {
            var result = await _componentTypeService.SaveChangesAsync(null);
            Assert.IsNotNull(result);
        }
    }
}