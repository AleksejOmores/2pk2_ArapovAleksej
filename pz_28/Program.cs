
using System;
namespace pz_28
{
    class Student
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler? Notify;
        public double averageGrade = 0;

        public Student(int grade)
        {
            averageGrade = grade;
        }

        public double GetAverageGrade(double averageGrade)
        {
            return averageGrade;
        }
    }

    class Teacher
    {
        private const double CRITICAL_GRADE = 2.4;

        public void CheckStudentPerformance(Student student)
        {
            if (student.GetAverageGrade(student.averageGrade) < CRITICAL_GRADE)
            {
                Console.WriteLine("Warning: student has low performance!");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stdt = new Student(100);
            int count = 0;
            double sum = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Впишите оценки ученика");
                sum +=  stdt.averageGrade = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            double Result = sum / count;
            Console.WriteLine($"Средняя оценка:{Result}");
            stdt.GetAverageGrade(Result);
        }
    }
}