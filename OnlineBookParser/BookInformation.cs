using System.Collections.Generic;

namespace OnlineBookParser
{
    internal class BookInformation
    {
        public string Published { get; set; } = string.Empty;
        public string ISBN13 { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
    }
}