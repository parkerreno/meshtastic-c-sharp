namespace Meshtastic;
public static class Resources
{
    public const int DEFAULT_BAUD_RATE = 115200;
    public const int DEFAULT_TCP_PORT = 4403;

    public const int DEFAULT_READ_TIMEOUT = 15000;
    public const int MAX_TO_FROM_RADIO_LENGTH = 512;

    /* Bluetooth Service GUID Constants */
    public static readonly Guid SERVICE_GUID = Guid.Parse("6ba1b218-15a8-461f-9fa8-5dcae273eafd");
    public static readonly Guid TO_RADIO_GUID = Guid.Parse("f75c76d2-129e-4dad-a1dd-7866124401e7");
    public static readonly Guid FROM_RADIO_GUID = Guid.Parse("2c55e69e-4993-11ed-b878-0242ac120002");
    public static readonly Guid FROM_NUM_GUID = Guid.Parse("ed9da18c-a800-4f66-a670-aa7547e34453");
    public static readonly Guid LOG_RADIO_GUID = Guid.Parse("5a3d6e49-06e6-4423-9944-e9de8cdf9547");
    public static readonly Guid LEGACY_LOG_RADIO_GUID = Guid.Parse("6c6fd238-78fa-436b-aacf-15c5be1ef2e2");
}