using PIUApp.ViewModels;

namespace PIUApp;

public partial class MainPage : ContentPage
{
	PostsViewModel viewModel;

	public MainPage(PostsViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext = viewModel;
	}

	protected override async void OnAppearing()
	{
		postsCollection.ItemsSource = viewModel.Posts;

		if (viewModel.FirstRun && viewModel.GetPostsCommand.CanExecute(null))
		{
			await viewModel.GetPostsCommand.ExecuteAsync(null);
			viewModel.FirstRun = false;
		}

		base.OnAppearing();
	}
}

