namespace CDWarehouse.Models;

public class CompactDiscSearchResult
{
    public string Artist { get; set; }
    public string Title { get; set; }

    public CompactDiscSearchResult(string artist, string title)
    {
        Artist = artist;
        Title = title;
    }
}