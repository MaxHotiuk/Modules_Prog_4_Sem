//Побудова ієрархії класів для користувачів бібліотеки: 
//базовий клас LibraryUser, який містить загальні властивості, та похідні класи, 
//наприклад, Student, Teacher тощо.
//Використання конструкторів для ініціалізації об'єктів класів та деструкторів для звільнення ресурсів.
namespace md_02;
public class Teacher : LibraryUser
{
    public string? TeacherId { get; set; }
    public Teacher(string name, string teacherId) : base(name)
    {
        TeacherId = teacherId;
    }
    ~Teacher()
    {
        Console.WriteLine("Teacher object is being deleted.");
    }
}