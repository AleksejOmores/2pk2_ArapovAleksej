namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double p = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            int i = 0;
            while (x < y)
            {
                x *= 1 + p / 100;
                x = (100 * x) / 100;
                i += 1;
                Console.WriteLine(i);
            }
        }
    }
}