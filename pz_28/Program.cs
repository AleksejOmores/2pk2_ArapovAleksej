using System;

namespace pz_28
{
    public delegate void AccountHandler(object sender, EventArgs e);

    class Student
    {
        public event AccountHandler Notify;

        public double AverageGrade { get; set; }

        public void Create()
        {
            if (Notify != null)
            {
                Notify(this, EventArgs.Empty);
            }
        }
        public static void Send(object sender, EventArgs e)
        {
            Console.WriteLine($"Оценка ученика нормальная");
        }
    }

    class Teacher
    {
        public static void Send(object sender, EventArgs e)
        {
            Console.WriteLine($"Оценка низкая, пора уже начинать учиться");
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            var stdt = new Student();

            int count = 0;
            double sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Введите оценку ученика: "); sum += stdt.AverageGrade = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                count++;
            }

            double result = sum / count;

            Console.WriteLine($"Средняя оценка: {result}");
            Console.WriteLine();

            if (result > 2.4)
            {
                stdt.Notify += Student.Send;
                stdt.Create();
            }
            else if (result <= 2.4)
            {
                stdt.Notify += Teacher.Send;
                stdt.Create();
            }
        }
    }
}