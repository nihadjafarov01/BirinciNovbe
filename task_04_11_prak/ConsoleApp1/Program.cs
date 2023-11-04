using ConsoleApp1.Exceptions;
using ConsoleApp1.Models;
using System.Net.Http.Headers;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        //Employee emp1 = new Employee()
        //{
        //    Name = "Nihad",
        //    Surname = "Jafarov",
        //    Age = 20
        //};
        //{
        //    Name = "socar"
        //};
        //company1.AddEmployee(emp1);
        //try
        //{
        //    Console.WriteLine(company1.GetEmployeeById(1));
        //    company1.RemoveEmployee(emp1);
        //    company1.RemoveEmployee(emp1);
        //}
        //catch (EmployeeNotFound ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

            Company company1 = new Company();
            char option = '0';
            char option4 = '0';
            Console.WriteLine("1. Create employee \n2. Get employee details by id \n3. Get all employees \n4. Update employee details id \n5. Delete employee records by id");
            do
            {
            try
            {
                Console.WriteLine("1, 2, 3, 4 or 5 ?");
                option = Convert.ToChar(Console.ReadLine());
                switch (option)
                {
                    case '1':
                        Employee emp1 = new Employee();
                        Console.Write("Name: ");
                        emp1.Name = Console.ReadLine();
                        Console.Write("Surname: ");
                        emp1.Surname = Console.ReadLine();
                        Console.Write("Age: ");
                        emp1.Age = Convert.ToByte(Console.ReadLine());
                        Console.Write("Name: ");
                        company1.AddEmployee(emp1);
                        break;
                    case '2':
                        Console.WriteLine("Enter id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        company1.GetEmployeeById(id);
                        break;
                    case '3':
                        company1.GetEmployees();
                        break;
                    case '4':
                        Console.WriteLine("Enter id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Employee getEmp1 = company1.GetEmployeeById(id);
                        //getEmp1.id
                        Console.WriteLine("What do you want to update? \n   1. Name\n   2. Gender\n   3. Salary\n   4. Position");
                        option4 = Convert.ToChar(Console.ReadLine());
                        switch (option4)
                        {
                            case '1':
                                Console.Write("Name: ");
                                string name = Console.ReadLine();
                                getEmp1.Name = name;
                                company1.UpdateEmployee(getEmp1);
                                break;
                            case '2':
                                Console.WriteLine("male, female or other ?");
                                Console.Write("Gender: ");
                                string genderStr = Console.ReadLine();
                                Gender inputAsEnum = (Gender)Enum.Parse(typeof(Gender), genderStr);
                                getEmp1.Gender = inputAsEnum;
                                company1.UpdateEmployee(getEmp1);
                                break;
                            case '3':
                                Console.Write("Salary: ");
                                decimal salary = Convert.ToDecimal(Console.ReadLine());
                                company1.UpdateEmployee(getEmp1);
                                break;
                            case '4':
                                Console.Write("Position: ");
                                string position = Console.ReadLine();
                                company1.UpdateEmployee(getEmp1);
                                break;
                        }
                        break;
                    case '5':
                        Console.Write("Id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        getEmp1 = company1.GetEmployeeById(id);
                        company1.RemoveEmployee(getEmp1);
                        break;
                        }
                }
            catch (EmployeeNotFound ex)
            {
                Console.WriteLine(ex.Message);
            }
            }
            while (option != 'q');
        }
    }