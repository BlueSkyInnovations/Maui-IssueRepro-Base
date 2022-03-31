namespace MauiIssueReproBase;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

	protected override Window CreateWindow(IActivationState activationState)
	{
		MainPage = new AppShell();
		return base.CreateWindow(activationState);
	}
}
