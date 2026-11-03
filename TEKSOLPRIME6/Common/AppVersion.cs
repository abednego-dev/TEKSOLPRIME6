using System.Reflection;
namespace TEKSOLPRIME6.Common;

public static class AppVersion
{
    public static string Display { get; } = Read();

    private static string Read()
    {
        var assembly = typeof(AppVersion).Assembly;

        var informational = assembly
            .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
            ?.InformationalVersion;

        if (!string.IsNullOrWhiteSpace(informational))
        {
            var plus = informational.IndexOf('+');

            return "v" + (plus >= 0
                ? informational.Substring(0, plus)
                : informational);
        }

        var version = assembly.GetName().Version;

        return version is null
            ? "v0.0.0"
            : $"v{version.ToString(3)}";
    }
}