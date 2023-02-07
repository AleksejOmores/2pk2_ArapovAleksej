using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace pz_21
{
    class Phone
    {

        public string Prefix { get; set; }
        public string Code { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }

        public static void GetPhoneNumber(ref string Prefix, ref string Code, ref string Number)
        {
            Console.WriteLine($"{Prefix}({Code}){Number}");
        }

        class Program
        {

            static void Main(string[] args)
            {
                string phoneFormat = "###-##-##";
                Phone phone = new Phone();
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
                    GetPhoneNumber(ref one, ref two, ref three);

                }
                if (phone.Type == "2")
                {

                    string one = phone.Prefix = "+7";
                    Console.Write("Введите первые 3 цифры: ");
                    string two = phone.Code = Console.ReadLine();
                    Console.Write("Введите последующие 7 цифр: ");
                    string three = phone.Number = Convert.ToInt32(Console.ReadLine()).ToString(phoneFormat);
                    Console.WriteLine();
                    GetPhoneNumber(ref one, ref two, ref three);

                }

            }

        }
    }
}