﻿using BinaryBox.Protocol.Settings;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace BinaryBox.Core.System.IO
{
    public interface IByteStream : IDisposable, INotifyPropertyChanged
    {
        ILogger Log { get; }
        IProtocolSettings Settings { get; set; }
        ByteStreamState State { get; }
        Task<ByteStreamResponse<ByteStreamState>> OpenAsync(CancellationToken cancellationToken = default);
        Task<ByteStreamResponse<ByteStreamState>> CloseAsync(CancellationToken cancellationToken = default);
        Task<ByteStreamResponse<bool>> DataAvailableAsync();
        Task<ByteStreamResponse<int>> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken = default);
        Task<ByteStreamResponse<bool>> WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken = default);
    }
}
