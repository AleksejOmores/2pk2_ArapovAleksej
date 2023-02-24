using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    internal class Phone
    {
        public string Prefix { get; set; }
        public string Code { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public static int const1 = 0;
        public static int const2 = 0;

        public virtual void GetPhoneNumber(ref string Prefix, ref string Code, ref string Number)
        {
            if (Prefix == "+1")
            {
                Console.WriteLine($"Введено корпоративных номеров: {const1} ");
                Console.WriteLine($"{Prefix}({Code}){Number}");
            }
            if (Prefix == "+7")
            {
                Console.WriteLine($"Введено личных номеров: {const2} ");
                Console.WriteLine($"{Prefix}({Code}){Number}");
            }
        }
    }
    class PrivatePhone : Phone
    {

        public List<string> Availabilities = new List<string>() { "Клиент", "Рабочий", "Начальник", "Сотрудник" };

        public override void GetPhoneNumber(ref string Prefix, ref string Code, ref string Number)
        {
            base.GetPhoneNumber(ref Prefix, ref Code, ref Number);
        }
    }
     
}
