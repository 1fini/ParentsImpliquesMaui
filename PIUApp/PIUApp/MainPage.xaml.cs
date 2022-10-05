using PIUApp.ViewModels;

namespace PIUApp;

public partial class MainPage : ContentPage
{
	public MainPage(PostsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}


}

