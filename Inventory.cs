//Joseph Thompson
using System;

using System.IO;

namespace Inventory
{
    class Inventory
    {
        static void Main(string[] args)
        {
            //Read Inventory Data
            StreamReader sr = new StreamReader(@"C:\Users\joeyt\source\repos\Inventory\Inventory\Inventory.txt");
            string data = sr.ReadLine();
            while(data != null)
            {
                Console.WriteLine(data);
                data = sr.ReadLine();
            }

            //Read Transaction Data
            StreamReader sr2 = new StreamReader(@"C:\Users\joeyt\source\repos\Inventory\Inventory\Transactions.txt");
            string transData = sr2.ReadLine();
            while (transData != null)
            {
                Console.WriteLine(transData);
                transData = sr2.ReadLine();
            }
        }
    }
}
