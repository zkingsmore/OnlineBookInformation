using Microsoft.EntityFrameworkCore;

namespace OnlineBookParser
{
    internal class SearchDB : BookInformation
    {
        private readonly BookContext _context;

        public SearchDB(BookContext context)
        {
            _context = context;
        }

        internal static async Task<BookInformation> findBookInDB(string title)
        {
            using (var context = new BookContext())
            {
                var bookInfoFound = await context.Books
                    .FirstOrDefaultAsync(b => b.Title.ToLower() == title.ToLower());

                return bookInfoFound;
            }
        }
    }
}
