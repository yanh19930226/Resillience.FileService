using System;
using System.Collections.Generic;
using System.Text;

namespace Resillience.FileService.Service.Models.Result
{
    /// <summary>
    /// 文件上传结果数据
    /// </summary>
    public class UploadData
    {
        /// <summary>
        /// 文件访问令牌
        /// </summary>
        public string FileToken { get; set; }
        /// <summary>
        /// 文件下载根地址
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 文件信息
        /// </summary>
        public FileInfo FileInfo { get; set; }
    }
}
