namespace MauiIssueReproBase.ViewModels;

public partial class AboutViewModel : BaseViewModel
{
    int count = 0;

	[ObservableProperty]
	string counterLabelText = "Current count: 0";

    public AboutViewModel()
    {
		Title = "About";
    }

    [ICommand]
	void OnCounterClicked()
	{
		count++;
		CounterLabelText = $"Current count: {count}";

		SemanticScreenReader.Announce(CounterLabelText);
	}
}
