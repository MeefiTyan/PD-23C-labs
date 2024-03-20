using System;

class Author
{
    private string authorName;

    public Author(string author)
    {
        authorName = author;
    }

    public void Show()
    {
        Console.WriteLine("Author: " + authorName);
    }
    public string AuthorName
    {
        get { return authorName; }
        set { authorName = value; }
    }
}
