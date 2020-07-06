using CloudinaryDotNet;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCManager.Data.Interfaces;
using SCManager.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SCManager.Tests.Services
{
    [TestClass]
    public class CloudinaryServiceTests
    {
        private readonly ICloudinaryService _cloudinaryService;

        public CloudinaryServiceTests()
        {
            var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

            Account account = new Account(
                    configuration["Cloudinary:CloudName"],
                    configuration["Cloudinary:ApiKey"],
                    configuration["Cloudinary:ApiSecret"]);

            var cloudinary = new Cloudinary(account);
            _cloudinaryService = new CloudinaryService(cloudinary);
        }

        [TestMethod]
        public async Task UploadImageAsync_WhenArgumentIsNull_ShouldReturnNull()
        {
            var result = await _cloudinaryService.UploadImageAsync(null);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void UploadImagesAsync_WhenArgumentIsNull_ShouldReturnNull()
        {
            var result = _cloudinaryService.UploadImagesAsync(null);
            Assert.IsNull(result.GetAsyncEnumerator().Current);
        }

        [TestMethod]
        public void UploadImagesAsync_WhenArgumentIsEmpty_ShouldReturnNull()
        {
            IEnumerable<IFormFile> files = new List<IFormFile>();

            var result = _cloudinaryService.UploadImagesAsync(files);
            Assert.IsNull(result.GetAsyncEnumerator().Current);
        }

        [TestMethod]
        public async Task DeleteImageAsync_WhenArgumentIsNull_ShouldReturnFalse()
        {
            var result = await _cloudinaryService.DeleteImageAsync(null);
            Assert.IsFalse(result);
        }
    }
}