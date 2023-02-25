using System;

namespace pz_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrivatePhone Privat = new PrivatePhone();
            bool correct = true;
            Random rnd = new Random();
            int rndnumber = rnd.Next(1000000, 9999999);
            string phoneFormat = "###-##-##";
            int[] Array = { 932, 987, 3532 };
            int mArray = rnd.Next(Array.Length);
            int[] Array1 = { 963, 918, 988 };
            int mArray1 = rnd.Next(Array.Length);
            Phone phone = new Phone();
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
                    string one = phone.Prefix = "+1";
                    string two = phone.Code = Convert.ToString(Array[mArray]);
                    string three = phone.Number = rndnumber.ToString(phoneFormat);
                    Console.WriteLine();
                    Phone.const1++;
                    Privat.GetPhoneNumber(ref one, ref two, ref three);
                    correct = false;
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
                    string one = phone.Prefix = "+7";
                    string two = phone.Code = Convert.ToString(Array1[mArray1]);
                    string three = phone.Number = rndnumber.ToString(phoneFormat);
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