using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.Services;
using System.Threading.Tasks;

namespace SCManager.Tests.Services
{
    [TestClass]
    public class UserComponentTypeServiceTests : BaseTest
    {
        private readonly IUserComponentTypeService userComponentTypeService;

        public UserComponentTypeServiceTests()
        {
            userComponentTypeService = new UserComponentTypeService(SCManagerDbContext);
        }

        [TestMethod]
        public async Task GetByIdAsync_WhenIdIsNull_ShouldReturnNull()
        {
            var result = await userComponentTypeService.GetByIdAsync(null);
            Assert.IsNull(result);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(-2)]
        public async Task GetByUserComponentTypeId_WhenIdIsInvalid_ShouldReturnEmptyCollection(int value)
        {
            var result = await userComponentTypeService.GetByIdAsync(value);
            Assert.IsNull(result);
        }

        [TestMethod]
        public async Task GetAllForUserId_WhenUserIdIsNull_ShouldReturnEmptyCollection()
        {
            var result = userComponentTypeService.GetAllForUserId(null);
            var hasAny = await result.AnyAsync();
           
            Assert.IsTrue(!hasAny);
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow("asdasd")]
        public async Task GetAllForUserId_WhenUserIdIsInvalid_ShouldReturnEmptyCollection(string value)
        {
            var result = userComponentTypeService.GetAllForUserId(value);
            var hasAny = await result.AnyAsync();

            Assert.IsTrue(!hasAny);
        }

        [TestMethod]
        public async Task SaveComponentAsync_WhenArgumentIsNull_ShouldReturnFalse()
        {
            var result = await userComponentTypeService.SaveComponentAsync(null);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public async Task SaveComponentAsync_WhenArgumentIsIInvalid_ShouldReturnFalse()
        {
            var type = new UserComponentType();
            var result = await userComponentTypeService.SaveComponentAsync(type);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public async Task UpdateComponentAsync_WhenArgumentIsNull_ShouldReturnFalse()
        {
            var result = await userComponentTypeService.UpdateComponentAsync(null);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public async Task UpdateComponentAsync_WhenArgumentIsIInvalid_ShouldReturnFalse()
        {
            var type = new UserComponentType { Id = 3 };
            var result = await userComponentTypeService.UpdateComponentAsync(type);

            Assert.IsFalse(result);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(-2)]
        public async Task DeleteAsync_WhenUserIdIsInvalid_ShouldReturnFalse(int value)
        {
            var result = await userComponentTypeService.DeleteAsync(value);
            Assert.IsFalse(result);
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow("asdasd")]
        public async Task DeleteAllForUserIdAsync_WhenUserIdIsInvalid_ShouldReturnFalse(string value)
        {
            var result = await userComponentTypeService.DeleteAllForUserIdAsync(value);
            Assert.IsFalse(result);
        }
    }
}