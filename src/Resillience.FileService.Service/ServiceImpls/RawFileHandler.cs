using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Resillience.FileService.Db.Repositories;
using Resillience.FileService.Service.Models;
using Resillience.FileService.Service.Options;
using Resillience.FileService.Service.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Resillience.FileService.Service.ServiceImpls
{
    /// <summary>
    /// 原始文件处理器
    /// </summary>
    public class RawFileHandler : IFileHandler
    {
        private readonly IOptionsMonitor<GeneralOption> _options;
        private readonly IRepositoryAccessor _repoAccessor;

        public RawFileHandler(IOptionsMonitor<GeneralOption> options, IRepositoryAccessor repoAccessor)
        {
            _options = options;
            _repoAccessor = repoAccessor;
        }

        public string Name => "raw";
        public IModifierDescribe ModifierDescribe { get; } = new RawModifierDescribe();

        public async Task<IActionResult> HandleAsync(FileHandleContext context)
        {
            if (!System.IO.File.Exists(context.SourcePath))
                return new NotFoundResult();

            string fileName = null;
            if (_options.CurrentValue.QueryFileName)
                fileName = await FileRepository.GetFileNameByIdAsync(context.FileToken.PseudoId, context.FileToken.FileOwnerId);
            return new PhysicalFileResult(context.SourcePath, context.SourceMime.ContentType)
            {
                FileDownloadName = fileName
            };
        }

        private IFileRepository FileRepository => _repoAccessor.GetRequiredRepository<IFileRepository>();
    }
}
