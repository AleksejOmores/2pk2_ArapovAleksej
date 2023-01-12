namespace pz_14
{
    internal class Program
    {
        static int step(int a1, int d, int n1)
        {
            if (n1 == 1)
            {
                return a1;
            }
            else
            {
                a1 += d;
                n1--;
                int x = step(a1, d, n1);
                return x;
            }
        }

        static double Geometry(double b1, double q, int n2)
        {
            if (n2 == 1)
            {
                return b1;
            }
            else
            {
                b1 *= q;
                n2--;
                double x = Geometry(b1, q, n2);
                return x;
            }
        }
        static int Whole(int A, int B)
        {
            if (A == B)
            {
                return B;
            }
            else
            {
                A++;
                Console.WriteLine(A);
                return Whole(A, B);
            }
        }


        static void Main(string[] args)
        {
            int a1 = 100, d = 10;
            Console.Write("Введите N: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(step(a1, d, n1));

            double b1 = 4, q = 0.1;
            Console.Write("Введите N: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Round(Geometry(b1, q, n2), 9));

            int A = 5, B = 65;
            Console.WriteLine();
            Console.WriteLine(Whole(A, B));

        }
    }
}