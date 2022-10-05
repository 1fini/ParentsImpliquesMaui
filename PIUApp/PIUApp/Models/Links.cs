using System.Collections.Generic;

namespace PIUApp.Models;

public class Links
{
    public List<Self> self { get; set; }
    public List<Collection> collection { get; set; }
    public List<About> about { get; set; }
    public List<Author> author { get; set; }
    public List<Reply> replies { get; set; }

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
    public List<Cury> curies { get; set; }
}