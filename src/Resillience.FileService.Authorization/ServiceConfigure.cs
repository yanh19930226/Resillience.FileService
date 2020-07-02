using Microsoft.Extensions.DependencyInjection;
using Resillience.FileService.Authorization.Codecs;
using Resillience.FileService.Authorization.Codecs.Impls;
using Resillience.FileService.Authorization.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resillience.FileService.Authorization
{
    /// <summary>
    /// FileService的IServiceCollection扩展
    /// </summary>
    public static class ServiceConfigure
    {
        /// <summary>
        /// 添加FileService.Sdk.Server的相关服务
        /// </summary>
        public static void AddAuthorization(IServiceCollection services)
        {
            services.AddSingleton<IOwnerTokenCodec, OwnerTokenCodec>();
            services.AddSingleton<IUrlDataCodec, UrlDataCompatibilityCodec>();
            services.AddSingleton<AppSecretSigner>();
        }

        public static void AddAuthorization(IServiceCollection services, Action<AuthOption> configure)
        {
            AddAuthorization(services);

            services.Configure(configure);
        }
    }
}
