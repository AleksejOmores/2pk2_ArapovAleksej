namespace pz_5;
class Program
{
        static void Main(string[] args)
        {
            char simvol = 'd';
            Console.WriteLine("Задание 1");
            for (int i = 0; i <= 70; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Задание 2");
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine(simvol);
                simvol++;
            }
            Console.WriteLine("Задание 3");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine('#');
                }
                Console.WriteLine();
            }
            Console.WriteLine("Задание 4");
            for (int i = 0; i < 100; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Задание 5");
            for (int i = 2, j = 40; j - i >= 25; i++, j--)
            {
                Console.WriteLine(i);
                Console.WriteLine(j);
            }
        }
    }
