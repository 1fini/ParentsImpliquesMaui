namespace PIUApp.ViewModels
{
    [QueryProperty(nameof(Post), "Post")]
    public partial class PostDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        Post post;

        [ObservableProperty]
        bool isRefreshing;

        public PostDetailsViewModel()
        {
            Title = "Details";
        }
    }
}
