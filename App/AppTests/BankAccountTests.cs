using Microsoft.VisualStudio.TestTools.UnitTesting;
using App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        public void TestExceptionCase()
        {
            BankAccount bank = new BankAccount("Vera", 0);
            try
            {
                bank.Debit(2);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "amount <=0 or amount > balance");
                return;
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "balane =0");
                return;
            }
            Assert.Fail("No exception was throw");
        }

        [TestMethod()]

        public void TestCreditCase()
        {
            BankAccount bank = new BankAccount("Vera", 2);
            bank.Credit(0);
            Assert.AreEqual(0, bank.Balance);
        }

        [TestMethod()]
        public void TestDebitCase()
        {
            BankAccount bank = new BankAccount("Vera", 2);
            bank.Debit(2);
            Assert.AreEqual(0, bank.Balance);
        }

        [TestMethod()]
        public void TestCreditDebitCase()
        {
            BankAccount bank = new BankAccount("Vera", 2);
            bank.Debit(2);
            bank.Credit(2);
            Assert.AreEqual(2, bank.Balance);
        }
    }
}
