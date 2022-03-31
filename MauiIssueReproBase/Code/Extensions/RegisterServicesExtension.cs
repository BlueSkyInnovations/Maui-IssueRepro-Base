using System.Reflection;

namespace MauiIssueReproBase.Code.Extensions;

public static partial class ConfigServicesExtensions
{
    public static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
    {
        var currentAssembly = Assembly.GetExecutingAssembly();

        // Transient objects lifetime services are created each time they are requested. This lifetime works best for lightweight, stateless services.
        foreach (var type in currentAssembly.DefinedTypes.Where(e => e.IsSubclassOf(typeof(Page)) || e.IsSubclassOf(typeof(BaseViewModel))))
        {
            builder.Services.AddTransient(type.AsType());
        }

        // Singleton objects are created as a single instance throughout the application. It creates the instance for the first time and reuses the same object in the all calls.
        

        return builder;
    }
}
