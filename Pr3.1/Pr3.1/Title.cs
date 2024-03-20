using System;

class Title
{
    private string bookTitle;

    public Title(string title)
    {
        bookTitle = title;
    }

    public void Show()
    {
        Console.WriteLine("Title: " + bookTitle);
    }
}
