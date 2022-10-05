using System.Net.Http.Json;
using PIUApp.Models;

namespace PIUApp.Services;

public class BlogService
{
    private readonly string BASE_ADDRESS = @"https://www.parentsimpliques.fr/wp/v2/";
    HttpClient Client {get;set;}
    List<Post> postsList;

    public BlogService()
    {
        this.Client = new HttpClient();
        Client.BaseAddress = new Uri(BASE_ADDRESS);
    }

    public async Task<List<Post>> GetPosts()
    {
        if(postsList?.Count > 0)
            return postsList;
        
        var response = await Client.GetAsync($"post");
        if (response.IsSuccessStatusCode)
        {
            postsList = await response.Content.ReadFromJsonAsync<List<Post>>();
        }

        return postsList;
    }
    
}