using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCManager.Data.Interfaces;
using SCManager.Services;
using System.Linq;
using System.Threading.Tasks;

namespace SCManager.Tests.Services
{
    [TestClass]
    public class UserComponentTypeDetailServiceTests : BaseTest
    {
        private readonly IUserComponentTypeDetailService _userComponentTypeDetailService;

        public UserComponentTypeDetailServiceTests()
        {
            _userComponentTypeDetailService = new UserComponentTypeDetailService(SCManagerDbContext);
        }

        [TestMethod]
        public void GetByUserComponentTypeId_WhenIdIsNull_ShouldReturnEmptyCollection()
        {
            var result = _userComponentTypeDetailService.GetByUserComponentTypeId(null);
            Assert.IsTrue(!result.Any());
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(-2)]
        public void GetByUserComponentTypeId_WhenIdIsInvalid_ShouldReturnEmptyCollection(int value)
        {
            var result = _userComponentTypeDetailService.GetByUserComponentTypeId(value);
            Assert.IsTrue(!result.Any());
        }

        [TestMethod]
        public async Task SaveDetailsAsync_WhenArgumentIsNull_ShouldReturnFalse()
        {
            var result = await _userComponentTypeDetailService.SaveDetailsAsync(null);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public async Task UpdateRangeAsync_WhenArgumentIsNull_ShouldReturnFalse()
        {
            var result = await _userComponentTypeDetailService.SaveDetailsAsync(null);
            Assert.IsFalse(result);
        }
    }
}