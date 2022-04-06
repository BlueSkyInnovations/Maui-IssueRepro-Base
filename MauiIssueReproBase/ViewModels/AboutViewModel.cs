using Command = MvvmHelpers.Commands.Command;

namespace MauiIssueReproBase.ViewModels;

public class AboutViewModel : BaseViewModel
{
    int count = 0;
		
	string counterLabelText = "Current count: 0";

	public string CounterLabelText
    {
		get => counterLabelText;
		set => SetProperty(ref counterLabelText, value);
    }

	public ICommand OnCounterClickedCommand { get; }

    public AboutViewModel()
    {
		Title = "About";
		OnCounterClickedCommand = new Command(OnCounterClicked);
    }
    
	private void OnCounterClicked()
	{
		count++;
		CounterLabelText = $"Current count: {count}";

		SemanticScreenReader.Announce(CounterLabelText);
	}
}
