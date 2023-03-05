using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Student
    {
        public string FirstName { get; set; }
        public List<int> Grades { get; set; }
        public Student(string firstName, List<int> grades)
        {
            FirstName = firstName;
            Grades = grades;
        }

        public double GetAverageGrade()
        {
            return Grades.Average();
        }
    }
}
