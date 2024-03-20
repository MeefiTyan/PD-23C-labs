class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("Harry Potter", "Joana Rowling", "Content of the book.");
        book.Show();

        book.Author = "J.K. Rowling";
        book.Content = "Updeted content";
        book.Show();
    }
}
