namespace MauiIssueReproBase;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		RegisterRoutes();
		BindingContext = new ShellViewModel();
	}

	// Application navigation URIs
	void RegisterRoutes()
	{
	}
}