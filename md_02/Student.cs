//Побудова ієрархії класів для користувачів бібліотеки: 
//базовий клас LibraryUser, який містить загальні властивості, та похідні класи, 
//наприклад, Student, Teacher тощо.
//Використання конструкторів для ініціалізації об'єктів класів та деструкторів для звільнення ресурсів.
namespace md_02;
public class Student : LibraryUser
{
    public string? StudentId { get; set; }
    public Student(string name, string studentId) : base(name)
    {
        StudentId = studentId;
    }
    ~Student()
    {
        Console.WriteLine("Student object is being deleted.");
    }
}