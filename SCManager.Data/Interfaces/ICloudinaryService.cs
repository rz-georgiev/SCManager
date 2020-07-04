using Microsoft.AspNetCore.Http;
using SCManager.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SCManager.Data.Interfaces
{
    public interface ICloudinaryService
    {
        Task<string> UploadImageAsync(IFormFile formFile);

        IAsyncEnumerable<string> UploadImagesAsync(IEnumerable<IFormFile> formFiles);

        Task<bool> DeleteImageAsync(string url);
    }
}