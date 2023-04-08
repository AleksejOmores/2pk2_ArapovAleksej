namespace _08._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sphere us1 = new Sphere(4, 0);
            Thread.Sleep(100);
            Sphere us2 = new Sphere(3, 4);

            Console.WriteLine(us1 + "\n" + us2);
            Console.WriteLine(us1 < us2);
        }
    }
}