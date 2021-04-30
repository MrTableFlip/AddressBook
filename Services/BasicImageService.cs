using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AddressBook.Services
{
    public class BasicImageService : IImageService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pic"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public string DecodeImage(byte[] pic, string contentType)
        {
            if (pic == null)
            {
                return null;
            }

            var picImage = Convert.ToBase64String(pic);
            return $"data:{contentType};base64,{picImage}";
        }

        public async Task<byte[]> EncodeImageAsync(IFormFile pic)
        {
            if(pic == null)
            {
                return null;
            }
            using var ms = new MemoryStream();
            await pic.CopyToAsync(ms);

            return ms.ToArray();
        }

        public async Task<byte[]> EncodeImageURLAsync(string imageURL)
        {
            var client = new HttpClient();

            var response = await client.GetAsync(imageURL);

            Stream stream = await response.Content.ReadAsStreamAsync();
            var ms = new MemoryStream();
            await stream.CopyToAsync(ms);

            return ms.ToArray();
        }

        public string RecordContentType(IFormFile pic)
        {
            if (pic == null)
            {
                return null;
            }
            return pic.ContentType;
        }
    }
}
