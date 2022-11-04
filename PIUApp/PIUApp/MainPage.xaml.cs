using PIUApp.ViewModels;
using static System.Net.Mime.MediaTypeNames;

namespace PIUApp;

public partial class MainPage : ContentPage
{
    PostsViewModel viewModel;

    public MainPage() { }

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
        carouselList.ItemsSource = viewModel.Posts.Take(3).ToList();

        base.OnAppearing();
    }
    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = entry.Text;
        postsCollection.ItemsSource = viewModel.Posts.Where(Post => Post.Title.Rendered.Contains(myText)).ToList();
    }
    void OnEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
        postsCollection.ItemsSource = viewModel.Posts.Where(Post => Post.Title.Rendered.Contains(text)).ToList();
    }
}

