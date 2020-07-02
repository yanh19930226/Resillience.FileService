using System;
using System.Collections.Generic;
using System.Text;

namespace Resillience.FileService.Service.Models
{
    /// <summary>
    /// 图像转换修饰信息
    /// </summary>
    public class ImageModifier
    {
        public ImageSize Size { get; set; }
        public Mime Mime { get; set; }
    }
}
