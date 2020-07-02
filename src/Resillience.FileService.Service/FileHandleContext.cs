using Resillience.FileService.Authorization;
using Resillience.FileService.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resillience.FileService.Service
{
    /// <summary>
    /// 文件处理上下文
    /// </summary>
    public class FileHandleContext
    {
        public string SourcePath { get; set; }
        public Mime SourceMime { get; set; }
        public string Modifier { get; set; }
        public FileToken FileToken { get; set; }
    }
}
