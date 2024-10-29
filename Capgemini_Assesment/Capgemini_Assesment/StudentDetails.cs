using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
    class StudentImplementation
    {
        public string NameOfAllStudents(IList<Student> students)
        {
            string name = "";
            foreach(Student student in students)
            {
                name += student.Name + ",";
            }
            if(name.Length>0)
            {
                name=name.Substring(0, name.Length-1);
            }
            return name;
        }
        public int TotalScoreOfAllStudents(IList<Student>students)
        {
            int total = 0;
            foreach (Student student in students)
            {
                total += student.Score;
            }
            return total;
        }
        public double AverageScore(IList<Student>students)
        {
            double Total = TotalScoreOfAllStudents(students);
            return Total/students.Count;
        }
    }
    public class StudentDetails
    {
        public static void Main(string[] args)
        {
            IList<Student> students = new List<Student>();
            students.Add(new Student
            {
                Name = "Alan",
                Score = 85,
            }) ;
            students.Add(new Student {
                Name = "Bob", Score = 92
            });
            students.Add(new Student { 
                Name = "Charlie", Score = 78
            });
            StudentImplementation studentImplementation = new StudentImplementation();
            Console.WriteLine( studentImplementation.NameOfAllStudents(students) );
            Console.WriteLine( studentImplementation.TotalScoreOfAllStudents(students));
            Console.WriteLine( studentImplementation.AverageScore(students));
        }
    }
}
