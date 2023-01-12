namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] A = new double[5, 10];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 10; j++)
                {
                    A[i, j] = rnd.NextDouble();
                }

            double sum = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                    sum += A[i, j];
                Console.WriteLine("Сумма равна " + sum);
            }
            Console.ReadKey();

            double mul = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                    mul *= A[i, j];
                Console.WriteLine("Произведение равна " + mul);
            }
            Console.ReadKey();
        }
    }
}