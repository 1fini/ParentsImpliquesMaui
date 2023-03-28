using PIUApp.ViewModels;

namespace PIUApp;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(PostDetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        //viewModel.Post.Content.rendered = ModifyHtmlContent(viewModel.Post.Content.rendered);
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }

    private string ModifyHtmlContent(string content)
    {
        if (!string.IsNullOrEmpty(content))
        {
            return content;
        }
        return content;
    }
}