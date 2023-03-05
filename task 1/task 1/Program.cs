using System;
using System.Collections.Generic;
using System.Linq;

namespace task_1
{


    class Program
    {
        static void Main(string[] args)
        {
            // Створення списку студентів
            List<Student> students = new List<Student>
        {
            new Student("John",  new List<int>{80, 90, 75}),
            new Student("Jane",  new List<int>{85, 90, 95}),
            new Student("Bob",   new List<int>{100, 90, 85}),
            new Student("Mary",  new List<int>{90, 80, 85})
        };

            // Фільтрація студентів, які отримали середній бал більше 85
            var filteredStudents = students.Where(s => s.GetAverageGrade() > 85);

            // Виведення результатів фільтрації
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} : {student.GetAverageGrade()}");
            }
        }
    }
}
