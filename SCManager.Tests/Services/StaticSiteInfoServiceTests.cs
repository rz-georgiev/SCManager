using Microsoft.Extensions.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.Services;
using System.Threading.Tasks;

namespace SCManager.Tests.Services
{
    [TestClass]
    public class StaticSiteInfoServiceTests : BaseTest
    {
        private readonly IStaticSiteInfoService _staticSiteInfoService;

        public StaticSiteInfoServiceTests()
        {
            _staticSiteInfoService = new StaticSiteInfoService(SCManagerDbContext);
        }

        [TestMethod]
        public void GetAll_WhenCalled_ShouldntReturnNull()
        {
            var result = _staticSiteInfoService.GetAll();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetByIdAsync_WhenIdIsNull_ShouldReturnNull()
        {
            var result = await _staticSiteInfoService.GetByIdAsync(null);
            Assert.IsNull(result);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(-2)]
        public async Task GetByIdAsync_WhenIdIsInvalid_ShouldReturnNull(int value)
        {
            var result = await _staticSiteInfoService.GetByIdAsync(value);
            Assert.IsNull(result);
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow(null)]
        public async Task GetByNameAsync_WhenNameIsNullOrWhitespace_ShouldReturnNull(string value)
        {
            var result = await _staticSiteInfoService.GetByNameAsync(value);
            Assert.IsNull(result);
        }

        [TestMethod]
        public async Task SaveChangesAsync_WhenARgumentIsNull_ShouldReturnFalse()
        {
            var result = await _staticSiteInfoService.SaveChangesAsync(null);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public async Task SaveChangesAsync_WhenARgumentIdIsInvalid_ShouldReturnFalse()
        {
            var info = new StaticSiteInfo();

            var result = await _staticSiteInfoService.SaveChangesAsync(info);
            Assert.IsFalse(result);
        }
    }
}