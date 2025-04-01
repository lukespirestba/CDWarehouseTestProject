namespace CDWarehouse.Models
{
    public class CDSearch
    {
        public CompactDiscSearchResult FindCDByArtistAndTitle(string artist, string title)
        {
            return new CompactDiscSearchResult(artist, title);
        }
    }
}