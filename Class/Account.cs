using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bank_Account.Enum;

namespace Bank_Account.Class
{
    public class Account
    {
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }

    }
}
