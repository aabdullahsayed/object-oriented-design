namespace LibraryManagementSystem.Services;

public class BookService
{
    private static readonly List<Book> _books = new List<Book>();

    public static void AddBook()
    {
        
        Book b = new Book();

        Console.WriteLine("Enter Book Title: ");
        b.title = Console.ReadLine();
        
        Console.WriteLine("Enter Book Author");
        b.author = Console.ReadLine();

        _books.Add(b);

    }

    public static void ShowBooks()
    {
        foreach (var book in _books)
        {
            Console.WriteLine($" ID {book.ID} Title: {book.title} Author: {book.author}");
        }
    }


}