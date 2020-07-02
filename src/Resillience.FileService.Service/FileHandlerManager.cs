using Microsoft.Extensions.DependencyInjection;
using Resillience.FileService.Service.ServiceImpls;
using Resillience.FileService.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Resillience.FileService.Service
{
    public class FileHandlerManager
    {
        private readonly Dictionary<string, IFileHandler> _fileHandlers;

        public FileHandlerManager(IServiceProvider services)
        {
            var handlers = new IFileHandler[]
            {
                services.GetRequiredService<RawFileHandler>(),
                services.GetRequiredService<ImageFileHandler>()
            };
            _fileHandlers = handlers.ToDictionary(p => p.Name);
        }

        public IFileHandler GetFileHandlerByName(string name)
        {
            _fileHandlers.TryGetValue(name, out var handler);
            return handler;
        }

        public IReadOnlyCollection<string> GetHandlersName() => _fileHandlers.Keys;
    }
}
