using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SCManager.Tests.Services
{
    [TestClass]
    public class ComponentTypeDetailServiceTests
    {
        private readonly IComponentTypeDetailService _componentTypeDetailService;

        public ComponentTypeDetailServiceTests()
        {
            var configuration = new ConfigurationBuilder()
           .AddJsonFile("appsettings.json")
           .Build();

            var options = new DbContextOptionsBuilder();
            options.UseSqlServer(configuration.GetConnectionString("SCManagerDbConnection"));

            var context = new SCManagerDbContext(options.Options);

            _componentTypeDetailService = new ComponentTypeDetailService(context);
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        [DataRow(-2)]
        public void GetByComponentTypeId_HasInvalidId_ReturnsEmptyCollection(int value)
        {
            var result = _componentTypeDetailService.GetByComponentTypeId(value);
            Assert.IsTrue(!result.Any());
        }

        [TestMethod]
        public async Task GetByIdAsync_HasNullId_ReturnsNull()
        {
            var result = await _componentTypeDetailService.GetByIdAsync(null);
            Assert.IsNull(result);
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        public async Task GetByIdAsync_HasInvalidId_ReturnsNull(int value)
        {
            var result = await _componentTypeDetailService.GetByIdAsync(value);
            Assert.IsNull(result);
        }

        [TestMethod]
        public async Task ResetPrimaryStatuses_HasNullArgument_ReturnsFalse()
        {
            var result = await _componentTypeDetailService.ResetPrimaryStatuses(null);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public async Task SaveChangesAsync_InvalidUpdateObject_ReturnsFalse()
        {
            var detail = new ComponentTypeDetail();
            var result = await _componentTypeDetailService.SaveChangesAsync(detail);

            Assert.IsFalse(result);
        }
    }
}