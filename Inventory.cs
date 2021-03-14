using System;
using System.IO;

namespace Inventory_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string INVENTORY = "Inventory.txt";
            const string TRANSACTIONS = "Transactions.txt";
            const char DELIM = ',';
            Warehouse wh = new Warehouse();
            FileStream fs = new FileStream(INVENTORY, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string invData;
            invData = sr.ReadLine();

            string[] whouses = {"Atlanta", "Baltimore", "Chicago", "Denver", "Ely", "Fargo"};
            string[] fields;
            Console.WriteLine("Inventory at the Beginning of the Day");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            int i = 0;

            while (invData != null && i < whouses.Length)
            {
                fields = invData.Split(DELIM);
                wh.item1 = Convert.ToInt32(fields[0]);
                wh.item2 = Convert.ToInt32(fields[1]);
                wh.item3 = Convert.ToInt32(fields[2]);
                wh.item4 = Convert.ToInt32(fields[3]);
                wh.item5 = Convert.ToInt32(fields[4]);

                Console.WriteLine("The {0} Warehouse has:", whouses[i]);
                Console.WriteLine("Part 102: {0}", wh.item1);
                Console.WriteLine("Part 215: {0}", wh.item2);
                Console.WriteLine("Part 410: {0}", wh.item3);
                Console.WriteLine("Part 525: {0}", wh.item4);
                Console.WriteLine("Part 711: {0}", wh.item5);
                Console.WriteLine();
                invData = sr.ReadLine();
                i++;
            }
            fs.Close();
            sr.Close();

            FileStream fs2 = new FileStream(TRANSACTIONS, FileMode.Open, FileAccess.Read);
            StreamReader sr2 = new StreamReader(fs2);
            string transData;
            transData = sr2.ReadLine();
            string[] fields2;
            Console.WriteLine("Inventory at the End of the Day");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            while (transData != null)
            {
                if (transData == "P")
                {

                }
                else if (transData == "S")
                {

                }
            }
        }
    }
}
