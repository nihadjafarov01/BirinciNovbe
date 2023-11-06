using ConsoleApp1.Exceptions;
using System.Collections.Generic;

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
            #region Find
            //Employee result = employees.Find(x => x.Id == id);
            //if (result == null)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    throw new EmployeeNotFound("Employee not found!");
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    return result;
            //}
            #endregion

            #region SingleOrDefault
            //Employee result = employees.SingleOrDefault(x => x.Id == id);
            //if (result == null)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    throw new EmployeeNotFound("Employee not found!");
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    return result;
            //}
            #endregion

            #region FirstOrDefault
            Employee result = employees.FirstOrDefault(x => x.Id == id);
            if (result == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new EmployeeNotFound("Employee not found!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return result;
            }
            #endregion
        }
        public void UpdateEmployee(Employee employee)
        {
            
        } 
        public void RemoveEmployee(int id)
        {
            #region Find
            Employee result = employees.Find(x => x.Id == id);
            if (result == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new EmployeeNotFound("Employee not found!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Employee removed");
                employees.Remove(result);
            }
            #endregion

            #region SingleOrDefault
            //Employee result = employees.SingleOrDefault(x => x.Id == id);
            //if (result == null)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    throw new EmployeeNotFound("Employee not found!");
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Employee removed");
            //    employees.Remove(result);
            //}
            #endregion

            #region FirstOrDefault
            //Employee result = employees.FirstOrDefault(x => x.Id == id);
            //if (result == null)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    throw new EmployeeNotFound("Employee not found!");
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Employee removed");
            //    employees.Remove(result);
            //}
            #endregion
        }
        public void GetEmployees()
        {
            employees.ForEach(delegate (Employee employee)
            {
                Console.WriteLine(employee);
            });
        }
    }
}
