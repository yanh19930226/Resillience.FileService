using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Resillience.FileService.Api.Controllers
{
    /// <summary>
    /// 客户端
    /// </summary>
    /// <returns></returns>
    [Route("api/user")]
    [ApiController]
    public class UserController : Controller
    {
        /// <summary>
        /// User
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}