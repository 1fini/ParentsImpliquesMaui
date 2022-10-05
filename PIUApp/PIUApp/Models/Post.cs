using System;
using Newtonsoft.Json;

namespace PIUApp.Models;


public class Post
{
    [JsonProperty("date")]
    public DateTime Date { get; set; }

    [JsonProperty("date_gmt")]
    public DateTime DateGmt { get; set; }

    [JsonProperty("guid")]
    public Guid Guid { get; set; }

    [JsonProperty("id")]
    public int Id { get; set; }

    Uri Link { get; set; }

    DateTime Modified { get; set; }

    DateTime ModifiedGMT { get; set; }

    string Slug { get; set; }

    string Status { get; set; }
    string Type { get; set; }

    [JsonProperty("permalink_template")]
    string PermalinkTemplate { get; set; }

    [JsonProperty("generated_slug")]
    string GeneratedSlug { get; set; }

    public Title Title { get; set; }

    Content Content { get; set; }

    Author author { get; set; }

    Excerpt Excerpt { get; set; }

    [JsonProperty("featured_media")]
    int FeaturedMedia { get; set; }

    [JsonProperty("comment_status")]
    string CommentStatus { get; set; }

    [JsonProperty("ping_status")]
    string PingStatus { get; set; }

    string Format { get; set; }

    bool Sticky { get; set; }
    string Template { get; set; }

    //List<Category> Categories {get;set;}

    //List<Tag> Tag {get;set;}



}


