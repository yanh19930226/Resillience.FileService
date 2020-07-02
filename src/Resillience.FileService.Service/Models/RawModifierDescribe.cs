using System;
using System.Collections.Generic;
using System.Text;

namespace Resillience.FileService.Service.Models
{
    /// <summary>
    /// 原始文件转换修饰信息描述
    /// </summary>
    public class RawModifierDescribe : IModifierDescribe
    {
        public string Syntax => "[raw]";
    }
}
