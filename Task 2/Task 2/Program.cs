using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = GetEmployeesFromDatabase();

            var sortedEmployees = employees.OrderBy(employee => employee.Salary);

            foreach (var employee in sortedEmployees)
            {
                Console.WriteLine($"{employee.Name} - {employee.Salary}");
            }
        }

        static List<Employee> GetEmployeesFromDatabase()
        {
            return new List<Employee> {
            new Employee { Name = "Saha", Salary = 4000 },
            new Employee { Name = "Mary", Salary = 10000 },
            new Employee { Name = "Walter", Salary = 6000 }};
        }
    }
}