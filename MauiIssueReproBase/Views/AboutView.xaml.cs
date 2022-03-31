namespace MauiIssueReproBase.Views;

public partial class AboutView : ContentPage
{
	AboutViewModel viewModel => BindingContext as AboutViewModel;

	public AboutView(AboutViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}

