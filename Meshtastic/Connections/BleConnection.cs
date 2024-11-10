using Google.Protobuf;
using Meshtastic.Data;
using Meshtastic.Protobufs;
using Microsoft.Extensions.Logging;

namespace Meshtastic.Connections;

public class BleConnection : DeviceConnection, IDisposable
{
    public BleConnection(ILogger logger) : base(logger)
    {
    }

    public BleConnection(ILogger logger, DeviceStateContainer container) : base(logger, container)
    {
    }

    public override void Disconnect()
    {
        throw new NotImplementedException();
    }

    public override Task ReadFromRadio(Func<FromRadio?, DeviceStateContainer, Task<bool>> isComplete, int readTimeoutMs = 15000)
    {
        throw new NotImplementedException();
    }

    public override Task<DeviceStateContainer> WriteToRadio(ToRadio toRadio, Func<FromRadio, DeviceStateContainer, Task<bool>> isComplete)
    {
        throw new NotImplementedException();
    }

    public override Task WriteToRadio(ToRadio toRadio)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}