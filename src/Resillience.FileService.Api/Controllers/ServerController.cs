using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Resillience.FileService.Api.Controllers
{
    /// <summary>
    /// 服务端接口
    /// </summary>
    [Route("api/server")]
    [ApiController]
    public class ServerController : Controller
    {
        /// <summary>
        /// 测试方法
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            throw new Exception("错误了");
        }
    }
}