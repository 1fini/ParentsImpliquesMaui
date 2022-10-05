using CommunityToolkit.Mvvm.Input;
using PIUApp.Services;


namespace PIUApp.ViewModels
{
    public partial class PostsViewModel : BaseViewModel
    {
        public ObservableCollection<Post> Posts { get; } = new();
        BlogService BlogService;
        IConnectivity connectivity;

        [ObservableProperty]
        bool isRefreshing;

        public PostsViewModel(BlogService blogService, IConnectivity connectivity)
        {
            Title = "Liste des articles";
            this.BlogService = blogService;
            this.connectivity = connectivity;
        }

        [RelayCommand]
        async Task GetPostsAsync()
        {
            if (IsBusy)
                return;

            try
            {
                if (connectivity.NetworkAccess != NetworkAccess.Internet)
                {
                    await Shell.Current.DisplayAlert("No connectivity!",
                        $"Please check internet and try again.", "OK");
                    return;
                }

                IsBusy = true;
                var posts = await BlogService.GetPosts();

                if (Posts.Count != 0)
                    Posts.Clear();

                foreach (var post in posts)
                    Posts.Add(post);

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get Posts: {ex.Message}");
                await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
                IsRefreshing = false;
            }

        }
    }
}
