﻿namespace BinaryBox.Protocol.Test
{
    public interface IFakeProtocolMessage<TProtocolSettings> : IProtocolMessage<TProtocolSettings>
        where TProtocolSettings : IProtocolSettings
    {

    }
}
