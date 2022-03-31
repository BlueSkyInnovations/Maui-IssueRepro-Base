namespace MauiIssueReproBase.Code.Extensions;

public static partial class ConfigServicesExtensions
{
    public static MauiAppBuilder RegisterFonts(this MauiAppBuilder builder)
    {
        return builder.ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("fa-brands-400.ttf", "FA-B");
            fonts.AddFont("fa-regular-400.ttf", "FA-R");
            fonts.AddFont("fa-solid-900.ttf", "FA-S");
        });
    }
}
