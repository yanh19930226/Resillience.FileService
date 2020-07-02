using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Resillience.FileService.Api.Controllers
{
    /// <summary>
    /// Cluster
    /// </summary>
    /// <returns></returns>
    public class ClusterController : Controller
    {
        /// <summary>
        /// Cluster
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}