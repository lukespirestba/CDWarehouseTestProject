using CDWarehouse.Models;

namespace TestProject
{
    internal class CDSearch
    {
        internal CompactDisc FindCDByArtistAndTitle(string artist, string title)
        {
            return new CompactDisc(1, artist, title);
        }
    }
}