using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Resillience.FileService.Api.Controllers
{
    /// <summary>
    /// 健康检查
    /// </summary>
    [Route("api/health")]
    [ApiController]
    public class HealthController : Controller
    {
        /// <summary>
        /// 健康检查
        /// </summary>
        [HttpGet]
        public IActionResult Get()
        {
            var res = "Healthy";
            return Ok(res);
        }
    }
}