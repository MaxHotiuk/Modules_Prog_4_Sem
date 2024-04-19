//Розробка класу винятків для обробки помилок у випадку виникнення 
//проблем під час видачі або повернення книги.
namespace md_02;
public class BookException : Exception
{
    public BookException(string message) : base(message)
    {
    }
}