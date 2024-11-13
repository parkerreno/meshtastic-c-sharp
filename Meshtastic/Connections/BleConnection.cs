using Google.Protobuf;
using Meshtastic.Data;
using Meshtastic.Protobufs;
using Microsoft.Extensions.Logging;
using Plugin.BLE.Abstractions.Contracts;
using System.Diagnostics.CodeAnalysis;

namespace Meshtastic.Connections;

/// <summary>
/// 
/// </summary>
[Experimental(diagnosticId: "BLESupport")]
public class BleConnection : DeviceConnection, IDisposable
{
    private readonly IDevice bleDevice;
    private readonly IAdapter? bleAdapter;
    
    private IService? meshtasticService;
    private ICharacteristic toRadio;
    private ICharacteristic fromRadio;
    private ICharacteristic fromNum;
    private ICharacteristic logRadio;
    private ICharacteristic legacyLogRadio;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="device"></param>
    /// <param name="logger"></param>
    /// <param name="adapter"></param>
    public BleConnection(IDevice device, ILogger logger, IAdapter? adapter = null) : base(logger)
    {
        this.bleDevice = device;
        this.bleAdapter = adapter;

        logger.LogInformation($"BleConnection started to device {device.Name}. Connection state: {device.State}. Pairing state: {device.BondState}.");
        if (adapter is null)
        {
            logger.LogInformation("Bluetooth adapter was not provided - not all functionality will be available.");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="device"></param>
    /// <param name="container"></param>
    /// <param name="logger"></param>
    /// <param name="adapter"></param>
    public BleConnection(IDevice device, DeviceStateContainer container, ILogger logger, IAdapter? adapter = null) : this (device, logger, adapter)
    {
        this.DeviceStateContainer = container;
    }

    /// <inheritdoc/>
    /// <exception cref="InvalidOperationException">This will be thrown if an adapter was not passed into the constructor on instantiation.</exception>
    public override async void Disconnect()
    {
        if (bleAdapter is null)
        {
            throw new InvalidOperationException("No Bluetooth adapter was provided - adapter must be provided on instantiation or method overload must be used.");
        }

        await this.Disconnect(bleAdapter);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="adapter">BLE Adapter that is connected to the device</param>
    /// <returns>Task completes when device is disconnected</returns>
    public async Task Disconnect(IAdapter adapter)
    {
        await adapter.DisconnectDeviceAsync(bleDevice);
    }

    /// <inheritdoc/>
    public override Task ReadFromRadio(Func<FromRadio?, DeviceStateContainer, Task<bool>> isComplete, int readTimeoutMs = 15000)
    {
        isComplete(null, this.DeviceStateContainer);
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public override Task<DeviceStateContainer> WriteToRadio(ToRadio toRadio, Func<FromRadio, DeviceStateContainer, Task<bool>> isComplete)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public override Task WriteToRadio(ToRadio toRadio)
    {
        throw new NotImplementedException();
    }

    private async Task ConnectToService()
    {
        if (meshtasticService is null)
        {
            meshtasticService = await bleDevice.GetServiceAsync(Resources.SERVICE_GUID);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public void Dispose()
    {
        throw new NotImplementedException();
    }
}