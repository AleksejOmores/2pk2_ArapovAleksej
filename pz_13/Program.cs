namespace pz_13
{
    internal class Program
    {
        static string StrArr(string a)
        {
            string text = null;
            string result = null;
            string[] Str = a.Split(' ');
            for (int i = 0; i < Str.Length; i++)
            {
                text = Str[i].Substring(0, 1).ToUpper();
                if (i == 0)
                {
                    result = text + Str[i].Substring(1) + " ";
                }
                else
                {
                    result += text + ".";
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine($"\"{StrArr(text)}\"");
        }
    }
}