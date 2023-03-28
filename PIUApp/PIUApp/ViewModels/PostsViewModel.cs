using CommunityToolkit.Mvvm.Input;
using PIUApp.Services;
using System.Text;
using System.Text.Encodings.Web;

namespace PIUApp.ViewModels
{
    public partial class PostsViewModel : BaseViewModel
    {
        public bool FirstRun { get; set; }

        public ObservableCollection<Post> Posts { get; } = new();
        BlogService BlogService;
        IConnectivity connectivity;

        [ObservableProperty]
        bool isRefreshing;

        public PostsViewModel(BlogService blogService, IConnectivity connectivity)
        {
            Title = "Articles";
            this.BlogService = blogService;
            this.connectivity = connectivity;
            this.FirstRun = true;
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
                {
                    post.ImageUrl = (await BlogService.GetFeaturedMedia(post.FeaturedMedia))?.source_url;
                    post.Title.Rendered = post.Title.Rendered;
                    Posts.Add(post);
                }
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

        [RelayCommand]
        async Task GoToDetails(Post post)
        {
            if (post == null)
                return;

            await Shell.Current.GoToAsync(nameof(DetailsPage), true, new Dictionary<string, object>
            {
                {"Post", post }
            });
        }
    }
}
