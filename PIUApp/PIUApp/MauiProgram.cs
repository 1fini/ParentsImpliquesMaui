using PIUApp.Services;
using PIUApp.ViewModels;

namespace PIUApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);

        builder.Services.AddSingleton<BlogService>();
        builder.Services.AddSingleton<PostsViewModel>();
        builder.Services.AddTransient<PostDetailsViewModel>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<HomePage>();
        builder.Services.AddTransient<DetailsPage>();

        return builder.Build();
    }
}
