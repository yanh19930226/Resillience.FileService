using System;
using System.Collections.Generic;
using System.Text;

namespace Resillience.FileService.Service.Services
{
    /// <summary>
    /// 服务器选取策略
    /// </summary>
    public interface IServerElectPolicy
    {
        Service.Options.Server ElectServer();
    }
}
