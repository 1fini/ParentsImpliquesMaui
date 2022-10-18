using System.Text.Json.Serialization;

namespace PIUApp.Models;


public class Post
{
    [JsonPropertyName("date")]
    public DateTime Date { get; set; }

    [JsonPropertyName("date_gmt")]
    public DateTime DateGmt { get; set; }

    [JsonPropertyName("guid")]
    public Guid Guid { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    Uri Link { get; set; }

    [JsonPropertyName("_links")]
    public Links Links { get; set; }

    DateTime Modified { get; set; }

    DateTime ModifiedGMT { get; set; }

    string Slug { get; set; }

    string Status { get; set; }
    string Type { get; set; }

    [JsonPropertyName("permalink_template")]
    string PermalinkTemplate { get; set; }

    [JsonPropertyName("generated_slug")]
    string GeneratedSlug { get; set; }

    public Title Title { get; set; }

    public Content Content { get; set; }

    public int Author { get; set; }

    public Excerpt Excerpt { get; set; }

    [JsonPropertyName("featured_media")]
    public int FeaturedMedia { get; set; }

    [JsonPropertyName("comment_status")]
    string CommentStatus { get; set; }

    [JsonPropertyName("ping_status")]
    string PingStatus { get; set; }

    string Format { get; set; }

    bool Sticky { get; set; }
    string Template { get; set; }

    //public List<Category> Categories {get;set;}

    //List<Tag> Tag {get;set;}

    public string ImageUrl { get; set; }
}


