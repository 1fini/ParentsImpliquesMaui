using System.Text.Json.Serialization;

namespace PIUApp.Models;

public class AsheFullThumbnail
{
    public string File { get; set; }
    public int Width { get; set; }
    public int height { get; set; }
    public int filesize { get; set; }
    public string mime_type { get; set; }
    public string source_url { get; set; }
}

public class AsheGridThumbnail
{
    public string file { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public int filesize { get; set; }
    public string mime_type { get; set; }
    public string source_url { get; set; }
}

public class AsheListThumbnail
{
    public string file { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public int filesize { get; set; }
    public string mime_type { get; set; }
    public string source_url { get; set; }
}

public class AsheSingleNavigation
{
    public string file { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public int filesize { get; set; }
    public string mime_type { get; set; }
    public string source_url { get; set; }
}

public class AsheSliderFullThumbnail
{
    public string file { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public int filesize { get; set; }
    public string mime_type { get; set; }
    public string source_url { get; set; }
}

public class Caption
{
    public string rendered { get; set; }
}

public class Description
{
    public string rendered { get; set; }
}

public class Full
{
    public string file { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public string mime_type { get; set; }
    public string source_url { get; set; }
}

public class ImageMeta
{
    public string aperture { get; set; }
    public string credit { get; set; }
    public string camera { get; set; }
    public string caption { get; set; }
    public string created_timestamp { get; set; }
    public string copyright { get; set; }
    public string focal_length { get; set; }
    public string iso { get; set; }
    public string shutter_speed { get; set; }
    public string title { get; set; }
    public string orientation { get; set; }
    public List<object> keywords { get; set; }
}

public class Large
{
    public string file { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public int filesize { get; set; }
    public string mime_type { get; set; }
    public string source_url { get; set; }
}

public class MediaDetails
{
    public int width { get; set; }
    public int height { get; set; }
    public string file { get; set; }
    public int filesize { get; set; }
    public Sizes sizes { get; set; }
    public ImageMeta image_meta { get; set; }
}

public class Medium
{
    public string file { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public int filesize { get; set; }
    public string mime_type { get; set; }
    public string source_url { get; set; }
}

public class MediumLarge
{
    public string file { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public int filesize { get; set; }
    public string mime_type { get; set; }
    public string source_url { get; set; }
}

public class Reply
{
    public bool embeddable { get; set; }
    public string href { get; set; }
}

public class Media
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
    public int author { get; set; }
    public string comment_status { get; set; }
    public string ping_status { get; set; }
    public string template { get; set; }
    public List<object> meta { get; set; }
    public Description description { get; set; }
    public Caption caption { get; set; }
    public string alt_text { get; set; }
    public string media_type { get; set; }
    public string mime_type { get; set; }
    public MediaDetails media_details { get; set; }
    public object post { get; set; }
    public string source_url { get; set; }
    public Links _links { get; set; }
}

public class Sizes
{
    public Medium medium { get; set; }
    public Large large { get; set; }
    public Thumbnail thumbnail { get; set; }
    public MediumLarge medium_large { get; set; }

    [JsonPropertyName("ashe-slider-full-thumbnail")]
    public AsheSliderFullThumbnail AsheSliderFullThumbnail { get; set; }

    [JsonPropertyName("ashe-full-thumbnail")]
    public AsheFullThumbnail AsheFullThumbnail { get; set; }

    [JsonPropertyName("ashe-list-thumbnail")]
    public AsheListThumbnail AsheListThumbnail { get; set; }

    [JsonPropertyName("ashe-grid-thumbnail")]
    public AsheGridThumbnail AsheGridThumbnail { get; set; }

    [JsonPropertyName("ashe-single-navigation")]
    public AsheSingleNavigation AsheSingleNavigation { get; set; }
    public Full Full { get; set; }
}

public class Thumbnail
{
    public string File { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Filesize { get; set; }

    [JsonPropertyName("mime_type")]
    public string MimeType { get; set; }

    [JsonPropertyName("source_url")]
    public string Source_url { get; set; }
}
