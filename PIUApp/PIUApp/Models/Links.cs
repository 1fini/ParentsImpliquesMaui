using Newtonsoft.Json;

namespace PIUApp.Models;

public class Links
{
    public List<Self> Self { get; set; }
    public List<Collection> Collection { get; set; }
    public List<About> About { get; set; }
    public List<Author> Author { get; set; }
    public List<Reply> Replies { get; set; }

    [JsonProperty("version-history")]
    public List<VersionHistory> VersionHistory { get; set; }

    [JsonProperty("predecessor-version")]
    public List<PredecessorVersion> PredecessorVersion { get; set; }

    [JsonProperty("wp:featuredmedia")]
    public List<WpFeaturedmedium> WpFeaturedmedia { get; set; }

    [JsonProperty("wp:attachment")]
    public List<WpAttachment> WpAttachment { get; set; }

    [JsonProperty("wp:term")]
    public List<WpTerm> WpTerm { get; set; }
    public List<Cury> Curies { get; set; }
}