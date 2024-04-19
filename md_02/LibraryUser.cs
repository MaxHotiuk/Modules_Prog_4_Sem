//Побудова ієрархії класів для користувачів бібліотеки: 
//базовий клас LibraryUser, який містить загальні властивості, та похідні класи, 
//наприклад, Student, Teacher тощо.
//Використання конструкторів для ініціалізації об'єктів класів та деструкторів для звільнення ресурсів.
namespace md_02;
public class LibraryUser
{
    public string? Name { get; set; }
    public List<Book> Books { get; set; }
    public LibraryUser(string name)
    {
        Name = name;
        Books = new List<Book>();
    }
    public void DisplayBooks()
    {
        Console.WriteLine($"Books of {Name}:");
        foreach (var book in Books)
        {
            Console.WriteLine($"{book.Title} by {book.Author}");
        }
    }
    public void IssueBook(Book book)
    {
        try 
        {
            book.Issue();
            Books.Add(book);
        }
        catch (BookException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void ReturnBook(Book book)
    {
        try
        {
            book.Return();
            Books.Remove(book);
        }
        catch (BookException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    ~LibraryUser()
    {
        Console.WriteLine("LibraryUser object is being deleted.");
    }
}