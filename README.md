# Maui-IssueRepro-Base
Base .NET MAUI Shell Application meant for reproducing issues

# Introduction
While working with .NET MAUI, we experienced a lot of issues. Looking at the reported issues within the .NET MAUI repository helps a lot. But sometimes it is necessary to report an issue ourselves. Of course we are aware of the fact that sometimes an issue could arise from its circumstances. Our apps are based on AppShell for instance. Also we are using the integrated dependency injection, sometimes Font Icons as well as other stuff.

So we created a base .NET MAUI Shell Application that includes most of our specific development strategies to be used in case we need to provide a repository that shows how to reproduce an issue we may have found.

# Specifics
This app is based currently based on .NET MAUI Preview 14 which has been shipped with Visual Studio 2022 17.2.0 Preview 2.1.
It uses the sample code you get when you create a new .NET MAUI app using the provided template.

We made the following changes:
- Switched to AppShell
- Bound AppShell to own ViewModel (ShellViewModel) containing data for Title, Icon, etc. (shout-out to James Montemagno and the [.NET PodCast repo](https://github.com/microsoft/dotnet-podcasts))
- Introduced a couple of folders for better organization (Views, ViewModels, Models, Code/Extensions)
- Installed CommunityToolkit.Mvvm NuGet-Package (for simplifying MVVM pattern (shout-out to James Montemagno and his [awesome Video about that here](https://youtu.be/aCxl0z04BN8)) 
- Introduced a BaseViewModel class as host for Title and IsBusy properties (since we don't use MvvmLight anymore in favor of the MCT)
- Organized .NET MAUI startup configuration using extensions (shout-out to Luis Matos [fantastic blog article about that here](https://luismts.com/organize-your-net-maui-mauiprogram-startup-file/))
- Moved font registration to an extension to the MauiAppBuilder
- Introduced .NET 6.0 Dependency Injection for registering ContentPages as well as ViewModels (based on BaseViewModel) also as an extension to the MauiAppBuilder  
- Moved original MainView-contents (counter-sample) to AboutView
- Introduced MCTs' ObservableProperty and ICommand to the AboutViewModel
- Added free FontAwesome fonts as MauiFonts
- Added static FontAwesomeIcons class for easy access to the glyphs
- Added GlobalUsings file to clean up the solution a bit
- Switched namespace declarations to file scoped namespaces

# Known Issues
Currently there seems to be still an issue regarding the display of the AppShells' initial pages' title. Although correctly bound to the respective ViewModels' Title property, the app displays the configured ApplicationTitle value from the project file instead. This is said to be already fixed. In this solution however, we set the ApplicationTitle to "Home" instead as a workaround. :)
