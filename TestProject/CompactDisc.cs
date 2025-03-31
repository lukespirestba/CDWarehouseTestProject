namespace TestProject
{
    internal class CompactDisc
    {
        private string Title { get; }
        private string Artist { get; }

        public CompactDisc(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }
    }
}