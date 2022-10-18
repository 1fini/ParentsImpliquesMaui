using System.Text.Json.Serialization;

namespace PIUApp.Models;

public class Links
{
    public List<Self> Self { get; set; }
    public List<Collection> Collection { get; set; }
    public List<About> About { get; set; }
    public List<Author> Author { get; set; }
    public List<Reply> Replies { get; set; }

    [JsonPropertyName("version-history")]
    public List<VersionHistory> VersionHistory { get; set; }

    [JsonPropertyName("predecessor-version")]
    public List<PredecessorVersion> PredecessorVersion { get; set; }

    [JsonPropertyName("wp:featuredmedia")]
    public List<WpFeaturedmedium> WpFeaturedmedia { get; set; }

    [JsonPropertyName("wp:attachment")]
    public List<WpAttachment> WpAttachment { get; set; }

    [JsonPropertyName("wp:term")]
    public List<WpTerm> WpTerm { get; set; }
    public List<Cury> Curies { get; set; }
}