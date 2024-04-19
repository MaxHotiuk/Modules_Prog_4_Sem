// Створення інтерфейсу ILibraryItem, який містить методи для видачі книги, 
// повернення книги та перевірки стану книги.
namespace md_02;
public interface ILibraryItem
{
    public void Issue();
    public void Return();
    public bool IsAvailable();
}