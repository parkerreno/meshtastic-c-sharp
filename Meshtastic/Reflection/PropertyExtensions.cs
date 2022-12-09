using System.Reflection;

namespace Meshtastic.Cli.Reflection;

public static class PropertyExtensions
{
    public static IEnumerable<PropertyInfo> GetProperties(this object instance)
    {
        var exclusions = new[] {
        "Version", "Parser", "Descriptor",
        "Name", "ClrType", "ContainingType",
        "Fields", "Extensions", "NestedTypes",
        "EnumTypes", "Oneofs", "RealOneofCount",
        "FullName", "File", "Declaration",
        "IgnoreIncoming"
    };

        return instance
            .GetType()
            .GetProperties()
            .Where(p => !exclusions.Contains(p.Name));
    }
    public static string GetSettingValue(this PropertyInfo property, object instance) =>
        (property.GetValue(instance)?.ToString() ?? string.Empty).Replace("[", string.Empty).Replace("]", string.Empty);
}