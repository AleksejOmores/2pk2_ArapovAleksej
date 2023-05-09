using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public delegate void AccountStateHandler(object sender, AccountEventArgs e);

    public class AccountEventArgs
    {
        public AccountEventArgs(string v, decimal sum)
        {
            V = v;
            Sum = sum;
        }

        public string V { get; }
        public decimal Sum { get; }
        public bool Message { get; set; }
    }
}
