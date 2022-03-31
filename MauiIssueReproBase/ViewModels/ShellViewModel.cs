namespace MauiIssueReproBase.ViewModels;

public class ShellViewModel
{
    public AppSection Home { get; set; }
    public AppSection About { get; set; }  

    public ShellViewModel()
    {
        Home = new AppSection() { Title = "Home", Icon = "home.png", IconDark = "home_dark.png", TargetType = typeof(HomeView) };
        About = new AppSection() { Title = "About", Icon = "about.png", IconDark = "about_dark.png", TargetType = typeof(AboutView) };
    }
}

