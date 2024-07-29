using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookParser
{
    internal class GetBookInformation : BookInformation
    {
        internal static async Task<BookInformation> GetBookInformationOnline(string title)
        {
            BookInformation bookInfo = new BookInformation();

            string url = "https://isbndb.com/search/books/";
            string criteria = title.Replace(" ", "%2B");
            string search = url + criteria;

            using var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(search);

            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(response);

            var bookRow = htmlDocument.DocumentNode.SelectNodes("//*[@id=\"block-multipurpose-business-theme-content\"]/div[1]/div[@class='book-row']");
            if(bookRow != null)
            {    
                foreach (var row in bookRow)
                {
                    var titleNode = row.SelectSingleNode(".//div[1]/div[3]/div[1]/div/h2/a");
                    var authorNode = row.SelectSingleNode(".//div[1]/div[3]/div[2]/div[1]/div[1]/div[2]/a");
                    var isbn13Node = row.SelectSingleNode(".//div[1]/div[3]/div[2]/div[1]/div[2]/div[2]");
                    var publishedNode = row.SelectSingleNode(".//div[1]/div[3]/div[2]/div[2]/div[1]/div[2]"); ////*[@id="block-multipurpose-business-theme-content"]/div[1]/div[1]/div[1]/div[3]/div[2]/div[2]
                    if (titleNode != null && string.Equals(titleNode.InnerText.ToLower().Trim(), title.ToLower(), StringComparison.OrdinalIgnoreCase))
                    {
                        bookInfo.Title = titleNode.InnerText.Trim();
                        bookInfo.Author = authorNode.InnerText.Trim();
                        bookInfo.ISBN13 = isbn13Node.InnerText.Trim();
                        bookInfo.Published = publishedNode.InnerText.Trim();
                        break;
                    }
                }
            }
            else
            {
                throw new Exception("No information was found.");
            }

            return bookInfo;
        }
    }
}
