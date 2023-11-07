using ConsoleApp1.Exceptions;

namespace ConsoleApp1.Models
{
    public static class EmployeeService
    {
        public static void AddEmployee(Employee employee)
        {
            CompanyDatabase.EmployeeList.Add(employee);
        }
        public static Employee GetEmployeeById(int id)
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
            Employee result = CompanyDatabase.EmployeeList.FirstOrDefault(x => x.Id == id);
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
        public static void UpdateEmployee(Employee employee)
        {

        }
        public static void RemoveEmployee(int id)
        {
            #region Find
            Employee result = CompanyDatabase.EmployeeList.Find(x => x.Id == id);
            if (result == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new EmployeeNotFound("Employee not found!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Employee removed");
                CompanyDatabase.EmployeeList.Remove(result);
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
        public static void GetEmployees()
        {
            CompanyDatabase.EmployeeList.ForEach(delegate (Employee employee)
            {
                Console.WriteLine(employee);
            });
        }
        public static List<Employee> GetEmployeesByValue(string value)
        {
            List<Employee> emps = new List<Employee> ();
            for (int i = 0; i < CompanyDatabase.EmployeeList.Count; i++)
            {
                if (CompanyDatabase.EmployeeList[0].Name == value || CompanyDatabase.EmployeeList[0].Name == value)
                {
                    emps.Add(CompanyDatabase.EmployeeList[0]);
                }          
            }
            return emps;
        }
        public static List<Employee> GetLatestEmployees()
        {
            List<Employee> emps = new List<Employee>();
            for (int i = 0; i < CompanyDatabase.EmployeeList.Count; i++)
            {
                if (CompanyDatabase.EmployeeList[i].CreatedAt == CompanyDatabase.EmployeeList[i].CurrentTime)
                {
                    emps.Add(CompanyDatabase.EmployeeList[i]);
                }
            }
            return emps;
        }
    }
}
