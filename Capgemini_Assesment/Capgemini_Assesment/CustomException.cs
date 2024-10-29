using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{

    public class CustomException:System.Exception
    {
        public string TransactionAmount { get; set; }
        public int AccountBalance {  get; set; }
        public int AccountName {  get; set; }

        public CustomException(string tr, int ab, int an)
        {
            TransactionAmount = tr;
            AccountBalance=ab;
            AccountName = an;
        }
    }
    class Account
    {
        public string Name { get; private set; }
        public int balance { get; private set; }

        public Account(string name, int Bal)
        {
            Name = name;
            balance = Bal;
        }
        public int Debit(int amount)
        {
            if (balance < amount)
            {
                throw new CustomException(Name, balance, amount);
            }
            else
            {
              //int res=  amount - balance;
              balance -=amount;
            }
            return balance;
        }
        public int Credit(int amount)
        {
            balance += amount;
            return balance;
        }

        class DC
        {
            public static void Main(string[] args)
            {
                
                    Account obj = new Account("sakshi", 70000);
                    Console.WriteLine(obj.Credit(1000));
                    Console.WriteLine(obj.Debit(500));
            }
        }
    }
}
