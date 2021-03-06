﻿using BinaryBox.Protocol.Settings;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace BinaryBox.Core.System.IO
{
    public interface IByteStreamManager : IDisposable, INotifyPropertyChanged
    {
        ILogger Log { get; }
        IProtocolSettings Settings { get; set; }
        ByteStreamState State { get; }
        Task<ByteStreamResponse<ByteStreamState>> OpenAsync(CancellationToken cancellationToken = default);
        Task<ByteStreamResponse<ByteStreamState>> CloseAsync(CancellationToken cancellationToken = default);
        Task<ByteStreamResponse<byte[]>> ReadAsync(int bytesToRead, CancellationToken cancellationToken = default);
        Task<ByteStreamResponse<byte[]>> ReadAsync(byte endOfText, int checksumLength = 0, CancellationToken cancellationToken = default);
        Task<ByteStreamResponse<bool>> WriteAsync(byte[] data, CancellationToken cancellationToken);
    }
}
