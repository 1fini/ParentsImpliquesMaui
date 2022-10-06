namespace PIUApp.Models;

public class WpFeaturedmedium
{
    public List<Data> Data {get;set;}
}

public class Data
{
    public bool Embeddable { get; set; }
    public string Href { get; set; }
}