using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_24
{
    public interface ICloneable
    {
        object Clone();
    }

    class Phone : ICloneable
    {
        public string Prefix { get; set; }
        public string Code { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }

        public Phone(string prefix, string code, string number, string type)
        {
            Prefix = prefix;
            Code = code;
            Number = number;
            Type = type;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }


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
            object Clone()
            {
                return MemberwiseClone();
            }
        }
    }
    internal class PrivatePhone : Phone
    {

        public List<string> Availabilities = new List<string>() { "Клиент", "Рабочий", "Начальник", "Сотрудник" };

        public PrivatePhone(string prefix, string code, string number, string type) : base(prefix, code, number, type)
        {

        }
        public override void GetPhoneNumber(ref string Prefix, ref string Code, ref string Number)
        {
            base.GetPhoneNumber(ref Prefix, ref Code, ref Number);
        }
    }
}
