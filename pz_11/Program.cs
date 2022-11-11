namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int stringlen = rnd.Next(1, 100);
            string str = "";
            char letter;
            for (int i = 0; i < stringlen; i++)
            {
                letter = Convert.ToChar(rnd.Next(0, 100));
                str = str + letter;
            }
            Console.WriteLine(str);
            Console.WriteLine();

            Console.WriteLine("Символов в тексте " + str.Length);
            Console.WriteLine();

            string result;

            if (str.Length % 2 == 0)
            {
                result = Convert.ToString(str.Substring(str.Length / 2, 1));
                Console.WriteLine("Количество четное, поэтому выводим один символ из центра: " + result);
            }
            else
            {
                result = Convert.ToString(str.Substring(str.Length / 2, 2));
                Console.WriteLine("Количество не четное, поэтому выводим два символа из центра: " + result);
            }
        }
    }
}