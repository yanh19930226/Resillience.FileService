﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Resillience.FileService.Service.Models.Result
{
    /// <summary>
    /// 操作结果接口定义
    /// </summary>
    public interface IResult
    {
        int ErrorCode { get; set; }
        string ErrorMsg { get; set; }
    }
}
