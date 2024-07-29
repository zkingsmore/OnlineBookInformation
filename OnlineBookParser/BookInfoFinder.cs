namespace OnlineBookParser;
using System;
using System.Windows.Forms;
public partial class BookInfoFinder : Form
{
    public BookInfoFinder()
    {
        InitializeComponent();
    }

    private async void findBkBtn_Click(object sender, EventArgs e)
    {
        string userInput = bkTtl.Text;

        try
        {
            BookInformation bookInfo = await GetBookInformation.GetBookInformationOnline(userInput);

            titleLbl.Text = bookInfo.Title;
            authorLbl.Text = bookInfo.Author;
            isbn13Lbl.Text = bookInfo.ISBN13;
            publishedLbl.Text = bookInfo.Published;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error retrieving book information: {ex.Message}");
        }
    }

    
}
