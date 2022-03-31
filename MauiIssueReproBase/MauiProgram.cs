using MauiIssueReproBase.Code.Extensions;

namespace MauiIssueReproBase;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.RegisterFonts()
			.RegisterServices();

		return builder.Build();
	}
}
