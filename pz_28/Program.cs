using System;

namespace pz_28
{
    public delegate void AccountHandler();
    class Student
    {
        public event AccountHandler Notify;

        public double AverageGrade { get; set; }

        public virtual void GetAverageGrade()
        {
            Console.WriteLine("Средняя оценка: {0}", AverageGrade);
        }
    }

    class Teacher : Student
    {
        private double CRITICAL_GRADE = 2.4;

        public override void GetAverageGrade()
        {
            
            Console.WriteLine("ееее");
            if (AverageGrade < CRITICAL_GRADE)
            {
                Console.WriteLine("Опасно!");
            }
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            Student stdt = new Student();
            int count = 0;
            double sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите оценку ученика");
                sum += stdt.AverageGrade = Convert.ToDouble(Console.ReadLine());
                count++;
            }
            double result = sum / count;
            stdt.AverageGrade = result;
            stdt.GetAverageGrade();
        }
    }
}