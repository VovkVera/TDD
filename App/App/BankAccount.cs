using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class BankAccount
    {
        string _customerName;
        double _balace;

        public BankAccount(string customerName, double balance)
        {
            _customerName = customerName;
            _balace = balance;
        }
        
        public double Balance { get { return _balace; } }

        public void Debit (double amount)
        {
            if (_balace == 0)
                throw new Exception("balance = 0");
            if (amount <= 0 || amount > _balace)
                throw new ArgumentOutOfRangeException("amount <=0 or amount > balance");
            _balace -= amount;

        }
            public void  Credit (double amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException("amount <=0");

        }
    }
}
