using Resillience.FileService.Db.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resillience.FileService.Service.Models
{
    public class FileStorageInfo
    {
        public File File { get; set; }
        public FileOwner Owner { get; set; }

        public Service.Options.Server Server { get; set; }

        public uint PseudoId { get; set; }
    }
}
