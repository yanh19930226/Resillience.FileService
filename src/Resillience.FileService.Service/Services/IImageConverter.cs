using Resillience.FileService.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Resillience.FileService.Service.Services
{
    /// <summary>
    /// 图像转换器
    /// </summary>
    public interface IImageConverter
    {
        Task ConvertAsync(string srcFilePath, Mime srcMime, string dstFilePath, ImageModifier dstImgMod);
    }
}
