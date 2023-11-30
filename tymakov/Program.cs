using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("УПР. 11.1 И 11.2.:Создать новый класс, который будет являться фабрикой объектов класса банковский счет и создать сборку. ");
            int account = BankFactory.CreateAccount();
            BankFactory.CreateAccount(12321);
            BankFactory.CreateAccount(Type.current);
            

            Dictionary<int, Bank2> accountsDictionary = BankFactory.AccountsDictionary;
            Console.WriteLine("Созданы банковские счета:");

            foreach (Bank2 bank in accountsDictionary.Values)
            {
                Console.WriteLine(bank.ToString());
            }

            BankFactory.ClosingAccount(account);
            Console.WriteLine($"Удален банковский счет под номером {account}:");

            foreach (Bank2 bank in accountsDictionary.Values)
            {
                Console.WriteLine(bank.ToString());
            }



            Console.WriteLine("Д/З 11.1 И 11.2.: создать новый класс Creator, который будет являться фабрикой объектов класса здания и создать сборку");
            int builder = Creator.CreateBuilder();
            Creator.CreateBuilder(20, 2);
            Creator.CreateBuilder(25, 5, 3, 2);

            Dictionary<int, Builder> buildingsDictionary = Creator.BuildingsDictionary;
            Console.WriteLine("Созданы здания:");

            foreach (Builder build in buildingsDictionary.Values)
            {
                Console.WriteLine(build.ToString());
            }

            Creator.RemoveBuilder(builder);
            Console.WriteLine($"Удалено здание под номером {builder}:");

            foreach (Builder build in buildingsDictionary.Values)
            {
                Console.WriteLine(build.ToString());
            }

        }
    }
}
