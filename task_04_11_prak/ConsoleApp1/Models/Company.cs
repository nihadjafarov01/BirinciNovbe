using ConsoleApp1.Exceptions;

namespace ConsoleApp1.Models
{
    internal class Company
    {
        public string Name { get; set; }
        List<Employee> employees = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public Employee GetEmployeeById(int id)
        {
            foreach (var item in employees)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            throw new EmployeeNotFound("Employee not found!!!");
        }
        public void UpdateEmployee(Employee employee)
        {
            
        } 
        public void RemoveEmployee(Employee emp)
        {
            employees.Remove(emp);
        }
        public void GetEmployees()
        {
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }
    }
}
