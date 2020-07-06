using Microsoft.Extensions.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.Services;
using System;
using System.Threading.Tasks;

namespace SCManager.Tests.Services
{
    [TestClass]
    public class UnitMultiplierServiceTests : BaseTest
    {
        private readonly IUnitMultiplierService _unitMultiplierService;

        public UnitMultiplierServiceTests()
        {
            _unitMultiplierService = new UnitMultiplierService(SCManagerDbContext);
        }

        [TestMethod]
        public void GetAll_WhenCalled_ShouldntReturnNull()
        {
            var result = _unitMultiplierService.GetAll();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetByIdAsync_WhenIdIsNull_ShouldReturnNull()
        {
            var result = await _unitMultiplierService.GetByIdAsync(null);
            Assert.IsNull(result);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(-2)]
        public async Task GetByIdAsync_WhenIdIsInvalid_ShouldReturnNull(int value)
        {
            var result = await _unitMultiplierService.GetByIdAsync(value);
            Assert.IsNull(result);
        }

        [TestMethod]
        public async Task SaveChangesAsync_WhenNewObjectIsInvalid_ShouldReturnFalse()
        {
            var multiplier = new UnitMultiplier();
            var result = await _unitMultiplierService.SaveChangesAsync(multiplier);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public async Task SaveChangesAsync_WhenNewObjectIsValid_ShouldReturnTrue()
        {
            var multiplier = new UnitMultiplier
            {
                Name = "",
                CreatedDateTime = DateTime.UtcNow,
                CreatedByUserId = "7b26038d-1a43-4248-90e1-dc7f0381d7fa",
                IsActive = true
            };
            var result = await _unitMultiplierService.SaveChangesAsync(multiplier);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public async Task SaveChangesAsync_WhenUpdateObjectIsInvalid_ShouldReturnFalse()
        {
            var multiplier = new UnitMultiplier();
            var result = await _unitMultiplierService.SaveChangesAsync(multiplier);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public async Task SaveChangesAsync_WhenUpdateObjectIsValid_ShouldReturnTrue()
        {
            var multiplier = new UnitMultiplier
            {
                Id = 1,
                Name = "",
                CreatedDateTime = DateTime.UtcNow,
                CreatedByUserId = "7b26038d-1a43-4248-90e1-dc7f0381d7fa",
                IsActive = true
            };
            var result = await _unitMultiplierService.SaveChangesAsync(multiplier);

            Assert.IsTrue(result);
        }

    }
}