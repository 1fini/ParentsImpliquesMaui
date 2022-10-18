using PIUApp.ViewModels;

namespace PIUApp;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(PostDetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}