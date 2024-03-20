using System;

class Content
{
    private string bookContent;

    public Content(string content)
    {
        bookContent = content;
    }

    public void Show()
    {
        Console.WriteLine("Content: " + bookContent);
    }
    public string BookContent
    {
        get { return bookContent; }
        set { bookContent = value; }
    }
}
