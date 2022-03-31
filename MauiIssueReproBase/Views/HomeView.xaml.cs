namespace MauiIssueReproBase.Views;

public partial class HomeView : ContentPage
{
	HomeViewModel viewModel => BindingContext as HomeViewModel;

	public HomeView(HomeViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}