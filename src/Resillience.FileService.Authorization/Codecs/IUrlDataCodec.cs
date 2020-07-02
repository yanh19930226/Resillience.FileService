using System;
using System.Collections.Generic;
using System.Text;

namespace Resillience.FileService.Authorization.Codecs
{
    /// <summary>
    /// URL承载的数据编解码器
    /// </summary>
    public interface IUrlDataCodec
    {
        string Encode(byte[] data);
        byte[] Decode(string encedStr);
    }
}
