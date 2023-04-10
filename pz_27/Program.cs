namespace pz_27
{
    class ZNAK
    {
        public string NAME;
        public string ZODIAC;
        public int[] BDAY = new int[3];
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            ZNAK znk = new ZNAK();
            ZNAK[] BOOK = new ZNAK[2];
            
            for (int i = 0; i < BOOK.Length; i++)
            {
                int x = rnd.Next(1, 30);
                int y = rnd.Next(1, 12);
                int z = rnd.Next(1988, 2023);
                Console.WriteLine("Введите данные {0}:", i + 1);

                Console.Write("Напишите Имя и Фамилию: ");
                string name = Console.ReadLine();

                Console.Write("Напишите свой задиак: ");
                string zodiac = Console.ReadLine();

                znk.BDAY[0] = x;
                znk.BDAY[1] = y;
                znk.BDAY[2] = z;

                Console.WriteLine($"Дата Рождения: {znk.BDAY[0]}.{znk.BDAY[1]}.{znk.BDAY[2]}" +
                    $"");
                BOOK[i] = new ZNAK { NAME = name, ZODIAC = zodiac };
            }
            Console.WriteLine("Введите имя или фамилию: ");
            string found = Console.ReadLine();

            foreach (ZNAK znak in BOOK)
            {
                if (znak.NAME == found)
                {
                    Console.WriteLine($"Вас зовут: {znak.NAME} Ваш знак Зодиака: {znak.ZODIAC} Вы родились: {znk.BDAY[0]}.{znk.BDAY[1]}.{znk.BDAY[2]}");
                }
                if (znak.NAME != found)
                {
                    Console.WriteLine($"Ваше Имя/Фамилия:{found} не были найдены в базе данных");
                }
            }
        }
    }
}