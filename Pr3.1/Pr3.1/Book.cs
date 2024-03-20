using System;

class Book
{
    private Title title;
    private Author author;
    private Content content;

    public Book(string bookTitle, string authorName, string bookContent)
    {
        title = new Title(bookTitle);
        author = new Author(authorName);
        content = new Content(bookContent);
    }
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        title.Show();
        Console.ForegroundColor = ConsoleColor.Cyan;
        author.Show();
        Console.ForegroundColor = ConsoleColor.Yellow;
        content.Show();
        Console.ResetColor();
    }

    public string Author
    {
        get { return author.AuthorName; }
        set { author.AuthorName = value;  }
    }

    public string Content
    {
        get { return content.BookContent; }
        set { content.BookContent = value; }
    }
}
