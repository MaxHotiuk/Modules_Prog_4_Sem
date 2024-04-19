// Створення класу Book, який реалізує інтерфейс ILibraryItem
// та містить інформацію про книгу (наприклад, назва, автор, рік видання тощо).
// Використання конструкторів для ініціалізації об'єктів класів та деструкторів для звільнення ресурсів.
// Визначення події для сповіщення про зміну статусу книги та організація взаємодії об'єктів через цю подію.
// Використати BookException для обробки винятків.
namespace md_02;
public class Book : ILibraryItem
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public int Year { get; set; }
    private bool _isAvailable = true;
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
    public delegate void StatusChangedHandler(string title, bool isAvailable);
    public event StatusChangedHandler? StatusChanged;
    public void OnIssued(string title, bool isAvailable)
    {
        StatusChanged?.Invoke(title, isAvailable);
        Console.WriteLine($"Book {Title} has been issued.");
    }
    public void OnReturn(string title, bool isAvailable)
    {
        StatusChanged?.Invoke(title, isAvailable);
        Console.WriteLine($"Book {Title} is now available.");
    }
    public void Issue()
    {
        if (_isAvailable)
        {
            _isAvailable = false;
            if (Title != null)
            {
                OnIssued(Title, _isAvailable);
            }
        }
        else
        {
            throw new BookException($"Book {Title} is not available.");
        }
    }
    public void Return()
    {
        if (!_isAvailable)
        {
            _isAvailable = true;
            if (Title != null)
            {
                OnReturn(Title, _isAvailable);
            }
        }
        else
        {
            throw new BookException($"Book {Title} is already available.");
        }
    }
    public bool IsAvailable()
    {
        return _isAvailable;
    }
    ~Book()
    {
        Console.WriteLine("Book object is being deleted.");
    }
}