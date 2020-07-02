using Resillience.FileService.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resillience.FileService.Service.Services
{
    public interface IMimeProvider
    {
        Mime GetMimeByExtensionName(string extName);
        Mime GetMimeByFile(string filePath, string extName);
        Mime GetMimeById(uint id);
        IEnumerable<string> ImageExtensionNames { get; }
    }
}
