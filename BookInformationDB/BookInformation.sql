CREATE TABLE [dbo].[BookInformation]
(
	ISBN13 NVARCHAR(13) NOT NULL PRIMARY KEY,
    Author NVARCHAR(255),
    Title NVARCHAR(255),
    PublishedYear INT
)
