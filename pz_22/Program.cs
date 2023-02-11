namespace pz_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool correct = true;
            string phoneFormat = "###-##-##";
            Phone phone = new Phone();
            while (correct)
            {
                Console.Write("Какой номер вам нужен? Корпоративный(1) или личный(2)?: ");
                phone.Type = Console.ReadLine();

                if (phone.Type == "1")
                {
                    string one = phone.Prefix = "+1";
                    Console.Write("Введите первые 3 цифры: ");
                    string two = phone.Code = Console.ReadLine();
                    Console.Write("Введите последующие 7 цифр: ");
                    string three = phone.Number = Convert.ToInt32(Console.ReadLine()).ToString(phoneFormat);
                    Console.WriteLine();
                    Phone.const1++;
                    Phone.GetPhoneNumber(ref one, ref two, ref three);
                    correct = false;
                }
                else if (phone.Type == "2")
                {
                    
                    string one = phone.Prefix = "+7";
                    Console.Write("Введите первые 3 цифры: ");
                    string two = phone.Code = Console.ReadLine();
                    Console.Write("Введите последующие 7 цифр: ");
                    string three = phone.Number = Convert.ToInt32(Console.ReadLine()).ToString(phoneFormat);
                    Console.WriteLine();
                    Phone.const2++;
                    Phone.GetPhoneNumber(ref one, ref two, ref three);
                    correct = false;
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
            }
        }

    }
}
