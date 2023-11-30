using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tymakov11
{
    public static class BankFactory
    {
        private static Dictionary<int, Bank2> accountsDictionary = new Dictionary<int, Bank2>();
        public static Dictionary<int, Bank2> AccountsDictionary
        {
            get
            {
                return accountsDictionary;
            }
        }
        public static int CreateAccount(double account_balance)
        {
            Bank2 account = new Bank2(account_balance);
            accountsDictionary.Add(account.AccountNumber, account);
            return account.AccountNumber;           
        }

        public static int CreateAccount(Type account_type)
        {
            Bank2 account = new Bank2(account_type);
            accountsDictionary.Add(account.AccountNumber, account);
            return account.AccountNumber;
        }
        public static int CreateAccount()
        {
            Bank2 account = new Bank2();
            accountsDictionary.Add(account.AccountNumber, account);
            return account.AccountNumber;
        }
        public static void ClosingAccount(int accountNumber)
        {
            accountsDictionary.Remove(accountNumber);
        }





    }
}
