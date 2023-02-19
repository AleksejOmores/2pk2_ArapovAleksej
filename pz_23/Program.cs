namespace pz_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrivatePhone Privat = new PrivatePhone();
            bool correct = true;
            string phoneFormat = "###-##-##";
            Phone phone = new Phone();
            while (correct)
            {
                Console.Write("Какой номер вам нужен? Корпоративный(1) или личный(2)?: ");
                phone.Type = Console.ReadLine();

                if (phone.Type == "1")
                {
                    Console.WriteLine("Кем вы являетесь?");
                    foreach (string Availability in Privat.Availability)
                    {
                        if (Availability == "Клиент" | Availability == "Рабочий")
                        {
                            Console.WriteLine("Доступ разрешен");
                            correct = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Доступ не разрешен");
                            return;
                        }
                    }
                    Console.WriteLine();
                    string one = phone.Prefix = "+1";
                    Console.Write("Введите первые 3 цифры: ");
                    string two = phone.Code = Console.ReadLine();
                    Console.Write("Введите последующие 7 цифр: ");
                    string three = phone.Number = Convert.ToInt32(Console.ReadLine()).ToString(phoneFormat);
                    Console.WriteLine();
                    Phone.const1++;
                    Privat.GetPhoneNumber(ref one, ref two, ref three);
                    correct = false;
                }
                else if (phone.Type == "2")
                {
                    Console.WriteLine("Кем вы являетесь?");
                    Console.ReadLine();
                    foreach (string b in Privat.Availability)
                    {
                        if (b == "Начальник" | b == "Сотрудник")
                        {
                            Console.WriteLine("Доступ разрешен");
                            correct = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Доступ не разрешен");
                            return;
                        }
                    }
                    string one = phone.Prefix = "+7";
                    Console.Write("Введите первые 3 цифры: ");
                    string two = phone.Code = Console.ReadLine();
                    Console.Write("Введите последующие 7 цифр: ");
                    string three = phone.Number = Convert.ToInt32(Console.ReadLine()).ToString(phoneFormat);
                    Console.WriteLine();
                    Phone.const2++;
                    Privat.GetPhoneNumber(ref one, ref two, ref three);
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