﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SCManager.Tests.Services
{
    [TestClass]
    public class ComponentTypeDetailServiceTests : BaseTest
    {
        private readonly IComponentTypeDetailService _componentTypeDetailService;

        public ComponentTypeDetailServiceTests()
        {
            _componentTypeDetailService = new ComponentTypeDetailService(SCManagerDbContext);
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        [DataRow(-2)]
        public void GetByComponentTypeId_WhenIdIsInvalid_ShouldReturnEmptyCollection(int value)
        {
            var result = _componentTypeDetailService.GetByComponentTypeId(value);
            Assert.IsTrue(!result.Any());
        }

        [TestMethod]
        public async Task GetByIdAsync_WhenIdIsNull_ShouldReturnNull()
        {
            var result = await _componentTypeDetailService.GetByIdAsync(null);
            Assert.IsNull(result);
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        public async Task GetByIdAsync_WhenIdIsInvalid_ShouldReturnNull(int value)
        {
            var result = await _componentTypeDetailService.GetByIdAsync(value);
            Assert.IsNull(result);
        }

        [TestMethod]
        public async Task ResetPrimaryStatuses_WhenArgumentIsNull_ShouldReturnFalse()
        {
            var result = await _componentTypeDetailService.ResetPrimaryStatuses(null);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public async Task SaveChangesAsync_WhenNewObjectIsInvalid_ShouldReturnFalse()
        {
            var detail = new ComponentTypeDetail();
            var result = await _componentTypeDetailService.SaveChangesAsync(detail);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public async Task SaveChangesAsync_WhenNewObjectIsValid_ShouldReturnTrue()
        {
            var detail = new ComponentTypeDetail
            {
                Name = "",
                Unit = "",
                Symbol = "",
                IsPrimary = true,
                ComponentTypeId = 1,
                CreatedDateTime = DateTime.UtcNow,
                CreatedByUserId = "7b26038d-1a43-4248-90e1-dc7f0381d7fa",
                IsActive = true
            };
            var result = await _componentTypeDetailService.SaveChangesAsync(detail);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public async Task SaveChangesAsync_WhenUpdateObjectIsInvalid_ShouldReturnFalse()
        {
            var detail = new ComponentTypeDetail();
            var result = await _componentTypeDetailService.SaveChangesAsync(detail);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public async Task SaveChangesAsync_WhenUpdateObjectIsValid_ShouldReturnTrue()
        {
            var detail = new ComponentTypeDetail
            {
                Id = 1,
                Name = "",
                Unit = "",
                Symbol = "",
                IsPrimary = true,
                ComponentTypeId = 1,
                CreatedDateTime = DateTime.UtcNow,
                CreatedByUserId = "7b26038d-1a43-4248-90e1-dc7f0381d7fa",
                IsActive = true
            };
            var result = await _componentTypeDetailService.SaveChangesAsync(detail);

            Assert.IsTrue(result);
        }
    }
}