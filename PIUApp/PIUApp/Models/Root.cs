namespace PIUApp.Models;
public class Root
{
    public int id { get; set; }
    public DateTime date { get; set; }
    public DateTime date_gmt { get; set; }
    public Guid guid { get; set; }
    public DateTime modified { get; set; }
    public DateTime modified_gmt { get; set; }
    public string slug { get; set; }
    public string status { get; set; }
    public string type { get; set; }
    public string link { get; set; }
    public Title title { get; set; }
    public Content content { get; set; }
    public Excerpt excerpt { get; set; }
    public int author { get; set; }
    public int featured_media { get; set; }
    public string comment_status { get; set; }
    public string ping_status { get; set; }
    public bool sticky { get; set; }
    public string template { get; set; }
    public string format { get; set; }
    public List<object> meta { get; set; }
    public List<int> categories { get; set; }
    public List<int> tags { get; set; }
    public string jetpack_featured_media_url { get; set; }
    public Links _links { get; set; }
}