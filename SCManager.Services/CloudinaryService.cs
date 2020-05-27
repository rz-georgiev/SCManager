using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using SCManager.Data.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace SCManager.HelperClasses
{
    public class CloudinaryService : ICloudinaryService
    {
        private readonly Cloudinary _cloudinary;

        public CloudinaryService(Cloudinary cloudinary)
        {
            _cloudinary = cloudinary;
        }

        public async Task<string> UploadImageAsync(IFormFile formFile)
        {
            using var stream = new MemoryStream();
            await formFile.CopyToAsync(stream);

            var imageArray = stream.ToArray();
            using var imageStream = new MemoryStream(imageArray);

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(formFile.Name, imageStream),
            };
            var uploadResult = await _cloudinary.UploadAsync(uploadParams);
            return uploadResult.PublicId;
        }

        public async IAsyncEnumerable<string> UploadImagesAsync(ICollection<IFormFile> formFiles)
        {
            foreach (var file in formFiles)
                yield return await UploadImageAsync(file);
        }

        public async Task DeleteImageAsync(string url)
        {
            await _cloudinary.DestroyAsync(new DeletionParams(url));
        }
    }
}