//кожен співробітник має такі властивості: Name, Position, HireDate
namespace md_03;
[Serializable]
public class Employee
{
    public string Name;
    public string Position;
    public string HireDate;
    public Employee()
    {
        Name = "Unknown";
        Position = "Unknown";
        HireDate = "Unknown";
    }
    public Employee(string name, string position, string hireDate)
    {
        Name = name;
        Position = position;
        HireDate = hireDate;
    }
}