using CDWarehouse.Models;

namespace TestProject;

public class CDSearchTest
{
    [Test]
    public void SearchCdByArtistAndTitle()
    {
        string artist = "Artist";
        string title = "Title";
        CDSearch search = new CDSearch();
        CompactDiscSearchResult cd = search.FindCDByArtistAndTitle(artist, title);

        Assert.That(cd != null);
        Assert.That(cd.Artist, Is.EqualTo(artist));
        Assert.That(cd.Title, Is.EqualTo(title));
    }
}
