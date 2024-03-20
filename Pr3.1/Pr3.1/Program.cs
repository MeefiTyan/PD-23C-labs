using System;

class Book
{
    private Title title;
    private Author author;
    private Content content;

    public Book(string title, string author, string content)
    {
        this.title = new Title(title);
        this.author = new Author(author);
        this.content = new Content(content);
    }

    public Title Title
    {
        get { return title; }
        set { title = value; }
    }

    public Author Author
    {
        get { return author; }
        set { author = value; }
    }

    public Content Content
    {
        get { return content; }
        set { content = value; }
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
}

class Title
{
    private string title;

    public Title(string title)
    {
        this.title = title;
    }

    public void Show()
    {
        Console.WriteLine("Title: " + title);
    }
}

class Author
{
    private string author;

    public Author(string author)
    {
        this.author = author;
    }

    public void Show()
    {
        Console.WriteLine("Author: " + author);
    }
}

class Content
{
    private string content;

    public Content(string content)
    {
        this.content = content;
    }

    public void Show()
    {
        Console.WriteLine("Content: " + content);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("Harry Potter", "J.K. Rowling", "Content of the book.");
        book.Show();
    }
}
