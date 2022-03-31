namespace MauiIssueReproBase.ViewModels;

public abstract partial class BaseViewModel : ObservableObject 
{
    [ObservableProperty]
    string title;

    [ObservableProperty]
    string isBusy;
}
