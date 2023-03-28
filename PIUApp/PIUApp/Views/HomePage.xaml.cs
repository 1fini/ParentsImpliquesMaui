using PIUApp.ViewModels;

namespace PIUApp;

public partial class HomePage : ContentPage
{
    PostsViewModel viewModel;
    public HomePage(PostsViewModel viewModel)
	{
		InitializeComponent();
        this.viewModel = viewModel;
        BindingContext = viewModel;
    }
    protected override async void OnAppearing()
    {
        if (viewModel.FirstRun && viewModel.GetPostsCommand.CanExecute(null))
        {
            await viewModel.GetPostsCommand.ExecuteAsync(null);
            viewModel.FirstRun = false;
        }
        carouselList.ItemsSource = viewModel.Posts.Take(3).ToList();

        base.OnAppearing();
    }
}