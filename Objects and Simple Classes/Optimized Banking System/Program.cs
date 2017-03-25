using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimized_Banking_System
{
    public class BankAccount
    {
        public string Name { get; set; }

        public string Bank { get; set; }

        public decimal Balance { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            List<BankAccount> bankAccount = new List<BankAccount>();

            while (inputLine !="end")
            {
                var input = inputLine.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

                var bank = input[0];
                var accountName = input[1];
                var accountBalance = input[2];

                var newBankAccount = new BankAccount();

                newBankAccount.Bank = bank;
                newBankAccount.Name = accountName;
                newBankAccount.Balance = decimal.Parse(accountBalance);

                bankAccount.Add(newBankAccount);

                inputLine = Console.ReadLine();
            }
            bankAccount = bankAccount
                .OrderByDescending(x => x.Balance)
                .ThenBy(x => x.Bank.Length)
                .ToList();

            foreach (var acc in bankAccount)
            {
                Console.WriteLine("{0} -> {1} ({2})",acc.Name,acc.Balance,acc.Bank);
            }
        }
    }
}
