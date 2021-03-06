//Joseph Thompson
using System;

using System.IO;

namespace Inventory
{
    class Inventory
    {
        static void Main(string[] args)
        {
            // Declare Global Variables
            const char DELIM = ',';
            const string INVENTORY = "Inventory.txt";
            const string TRANSACTIONS = "Transactions.txt";

            //Create Warehouse Object
            Warehouses warehouse = new Warehouses();

            //Read Inventory.txt Data
            FileStream file = new FileStream(INVENTORY, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(file);

            String textInput;
            string[] fields;
            Console.WriteLine("Inventory at the Beginning of the Day");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}\n", "Part 102", "Part 215", "Part 410", "Part 525", "Part 711");
            textInput = sr.ReadLine();
           // Console.WriteLine("{0,-10}{1,-12}{2,-10}{3,-10}{4,-7}", "Atlanta", "Baltimore", "Chicago", "Denver", "Ely", "Fargo");

           //Output Beginning Inventory Data
            while (textInput != null)
            {
                fields = textInput.Split(DELIM);
                warehouse.item1 = Convert.ToInt32(fields[0]);
                warehouse.item2 = Convert.ToInt32(fields[1]);
                warehouse.item3 = Convert.ToInt32(fields[2]);
                warehouse.item4 = Convert.ToInt32(fields[3]);
                warehouse.item5 = Convert.ToInt32(fields[4]);
                Console.WriteLine("{0,-10}{1,-12}{2,-10}{3,-10}{4,-7}", warehouse.item1, warehouse.item2, warehouse.item3, warehouse.item4, warehouse.item5);
                textInput = sr.ReadLine();
            }

            // Get Transaction Data
            FileStream file2 = new FileStream(TRANSACTIONS, FileMode.Open, FileAccess.Read);
            StreamReader sr2 = new StreamReader(file2);
            string transData;
            string[] fields2;
            transData = sr2.ReadLine();

            while( transData != null)
            {
                fields2 = transData.Split(',');
                warehouse.transType = fields2[0];
                warehouse.trans1 = Convert.ToInt32(fields2[1]);
                warehouse.trans2 = Convert.ToInt32(fields2[2]);
                transData = sr2.ReadLine();
            }

            //Output End of Day Inventory Data
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Inventory at the End of the Day");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("\n{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}\n", "Part 102", "Part 215", "Part 410", "Part 525", "Part 711");
            Console.WriteLine(warehouse);
            


            sr.Close();
            file.Close();
        }
    }
}
