using XmlSerializer = System.Xml.Serialization.XmlSerializer;
using System.Text;
namespace md_03;
class Program
{
    public static void SerializeToXML(List<Employee> employees, string filename)
    {
        try
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Employee>));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, employees);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public static List<Employee> DeserializeFromXML(string filename)
    {
        List<Employee> employees = new List<Employee>();
        try
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Employee>));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                employees = (List<Employee>)formatter.Deserialize(fs);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return employees;
    }
    public static List<Employee> SortByHireDate(List<Employee> employees)
    {
        return employees.OrderBy(x => x.HireDate).ToList();
    }
    public static void WriteToTextFile(List<Employee> employees, string filename)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(filename, false, Encoding.Default))
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    sw.WriteLine($"Name: {employees[i].Name}, Position: {employees[i].Position}, HireDate: {employees[i].HireDate}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static void Main()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee("John Doe", "Manager", "2010-04-01"));
        employees.Add(new Employee("Jane Smith", "Developer", "2015-06-23"));
        employees.Add(new Employee("Albert Johnson", "Analyst", "2008-11-15"));
        SerializeToXML(employees, "employees.xml");
        List<Employee> employeesFromXML = DeserializeFromXML("employees.xml");
        employeesFromXML = SortByHireDate(employeesFromXML);
        SerializeToXML(employeesFromXML, "sorted_employees.xml");
        WriteToTextFile(employeesFromXML, "employees.txt");
    }
}