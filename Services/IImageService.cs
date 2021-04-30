using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Services
{
    public interface IImageService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pic"></param>
        /// <returns></returns>
        Task<byte[]> EncodeImageAsync(IFormFile pic);

        //encode an Image from a URL
        Task<byte[]> EncodeImageURLAsync(string imageURL);

        string DecodeImage(byte[] pic, string contentType);

        string RecordContentType(IFormFile pic);


    }
}
