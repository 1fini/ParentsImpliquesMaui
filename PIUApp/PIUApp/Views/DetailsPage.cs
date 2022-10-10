using PIUApp.ViewModels;

namespace PIUApp.Views;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(PostDetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}