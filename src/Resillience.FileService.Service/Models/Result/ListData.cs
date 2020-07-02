using System;
using System.Collections.Generic;
using System.Text;

namespace Resillience.FileService.Service.Models.Result
{
    public class ListData<T>
    {
        /// <summary>
        /// 数据列表
        /// </summary>
        public IEnumerable<T> List { get; set; }
    }
}
