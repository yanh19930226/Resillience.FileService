using Microsoft.AspNetCore.Hosting;
using Resillience.FileService.Db.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Resillience.FileService.Db.Repositories.Impls;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resillience.FileService.Db
{
    /// <summary>
    /// DB层服务配置
    /// </summary>
    public class DbHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.AddScoped<MasterDbContext>();

                services.AddScoped<IFileRepository, FileRepository>();
                services.AddScoped<IOwnerRepository, OwnerRepository>();

                services.AddSingleton<IRepositoryAccessor, RepositoryAccessor>();
            });
        }
    }
}
