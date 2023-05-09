using System.Numerics;

namespace pz_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrivatePhone Privat = new PrivatePhone("1", "101", "7654321", "tip");
            bool correct = true;
            string phoneFormat = "###-##-##";
            Phone phone = new Phone("1", "101", "1234567", "tip");
            while (correct)
            {
                Console.Write("Какой номер вам нужен? Корпоративный(1) или личный(2)?: ");
                phone.Type = Console.ReadLine();

                if (phone.Type == "1")
                {
                    Console.WriteLine("Кем вы являетесь?");
                    string Contact = Console.ReadLine();
                    bool hasContact = Privat.Availabilities.Contains(Contact);
                    if ((Contact == "Клиент" || Contact == "Рабочий") && hasContact == true)
                    {
                        Console.WriteLine("Доступ предоставлен!");
                    }
                    else
                    {
                        Console.WriteLine("Не можем предоставить");
                        return;
                    }
                    Console.WriteLine();
                    string one = phone.Prefix = "+1";
                    Console.Write("Введите первые 3 цифры: ");
                    string two = phone.Code = Console.ReadLine();
                    Console.Write("Введите последующие 7 цифр: ");
                    string three = phone.Number = Convert.ToInt32(Console.ReadLine()).ToString(phoneFormat);
                    Console.WriteLine();
                    Phone.const1++;
                    phone.GetPhoneNumber(ref one, ref two, ref three);
                    correct = false;
                    Phone clone1 = (Phone)phone.Clone();
                    Console.WriteLine("Склонированный объект:"); Console.Write(clone1);
                }
                else if (phone.Type == "2")
                {
                    Console.WriteLine("Кем вы являетесь?");
                    string Contact = Console.ReadLine();
                    bool hasContact = Privat.Availabilities.Contains(Contact);
                    if ((Contact == "Начальник" || Contact == "Сотрудник") && hasContact == true)
                    {
                        Console.WriteLine("Доступ предоставлен!");
                    }
                    else
                    {
                        Console.WriteLine("Не можем предоставить");
                        return;
                    }
                    Console.WriteLine();
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