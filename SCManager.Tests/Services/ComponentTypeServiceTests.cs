using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.Services;
using System;
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
        public async Task SaveChangesAsync_InvalidNewObject_ReturnsFalse()
        {
            var type = new ComponentType();
            var result = await _componentTypeService.SaveChangesAsync(type);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public async Task SaveChangesAsync_ValidNewObject_ReturnsTrue()
        {
            var type = new ComponentType
            {
                Name = "",
                ImageId = "",
                CreatedDateTime = DateTime.UtcNow,
                CreatedByUserId = "7b26038d-1a43-4248-90e1-dc7f0381d7fa",
                IsActive = true
            };
            var result = await _componentTypeService.SaveChangesAsync(type);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public async Task SaveChangesAsync_InvalidUpdateObject_ReturnsFalse()
        {
            var type = new ComponentType();
            var result = await _componentTypeService.SaveChangesAsync(type);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public async Task SaveChangesAsync_ValidUpdateObject_ReturnsTrue()
        {
            var type = new ComponentType
            {
                Id = 1,
                Name = "",
                ImageId = "",
                CreatedDateTime = DateTime.UtcNow,
                CreatedByUserId = "7b26038d-1a43-4248-90e1-dc7f0381d7fa",
                IsActive = true
            };
            var result = await _componentTypeService.SaveChangesAsync(type);

            Assert.IsTrue(result);
        }
    }
}