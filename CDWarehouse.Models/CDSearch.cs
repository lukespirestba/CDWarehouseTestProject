namespace CDWarehouse.Models
{
    public class CDSearch
    {
        public CompactDisc FindCDByArtistAndTitle(string artist, string title)
        {
            return new CompactDisc(1, artist, title);
        }
    }
}