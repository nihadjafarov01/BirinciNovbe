namespace Company_Project;

public class Company
{
    string _name;
    public string Name
    {
        get
        {
            return this.Name;
        }
        set
        {

            if (!string.IsNullOrWhiteSpace(value))
            {
                value = value.Trim();
                this._name = value.ToUpper()[0] + value.Substring(1);
            }
        }
    }
    public Employee[] Employees; //new Employee[0]

    public Company(string name)
    {
        Name = name;
        Employees = new Employee[0];
    }

    public void AddUser(Employee employee)
    {
        Array.Resize(ref Employees, Employees.Length + 1);
        Employees[Employees.Length - 1] = employee;
        Console.WriteLine("Successfully added!");
    }
    public Employee GetUser(string username)
    {
        foreach (Employee emp in Employees)
        {
            Console.WriteLine(emp.Name);
            Console.WriteLine(emp.Surname);
            Console.WriteLine(emp.Username);

            if (emp.Username == username) {  return emp; }
        }
        Console.WriteLine("Employee with given username not found");
        return null;
    }

    public void GetAllUser()
    {
        foreach (Employee item in Employees)
        {
            Console.WriteLine(item.Username);
        }
    }
}
