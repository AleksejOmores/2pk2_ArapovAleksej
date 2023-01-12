namespace pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string s1 = str.Substring(0, str.IndexOf(' '));
            string s2 = str.Substring(str.LastIndexOf(' ') + 1);

            str = str.Remove(0, str.IndexOf(' '));
            str = str.Remove(str.LastIndexOf(' ') + 1);
            str = s2 + str + s1;

            Console.WriteLine(str);
        }
    }
}