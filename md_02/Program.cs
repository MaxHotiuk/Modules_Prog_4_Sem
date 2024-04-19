// Варіант 2
// Синхронний виклик методів через делегат для видачі та повернення книг.
namespace md_02;
public static class Program
{
    public delegate void LibraryItemHandler(Book book);
    public static void Print(object obj)
    {
        Console.WriteLine(obj);
    }
    public static void Main()
    {
        var book1 = new Book("Ufjdfj", "Idkd", 1977);
        var book2 = new Book("Ppfff", "Kdjd", 1988);
        var book3 = new Book("Kfjff", "Kdjd", 1988);
        var student = new Student("Ivan", "123");
        var teacher = new Teacher("Petro", "456");
        LibraryItemHandler studentIssueHandler = new LibraryItemHandler(student.IssueBook);
        LibraryItemHandler studentReturnHandler = new LibraryItemHandler(student.ReturnBook);
        LibraryItemHandler teacherIssueHandler = new LibraryItemHandler(teacher.IssueBook);
        LibraryItemHandler teacherReturnHandler = new LibraryItemHandler(teacher.ReturnBook);
        studentIssueHandler(book1);
        studentIssueHandler(book2);
        teacherIssueHandler(book3);
        student.DisplayBooks();
        teacherIssueHandler(book1);
        studentReturnHandler(book1);
        teacherIssueHandler(book1);
        student.DisplayBooks();
        teacher.DisplayBooks();
        teacherReturnHandler(book1);
    }
}