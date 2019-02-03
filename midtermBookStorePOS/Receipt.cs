using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermBookStorePOS
{

    class Receipt
    {        

        public static void PrintReceipt()
        {
            foreach (Book b in Program.Cart)
            {
                Console.WriteLine(b.Title + b.Author + b.Price + b.Quantity);
            }
			Console.WriteLine("Would you like to make another transaction? y/n");
			string finalAnswer = Console.ReadLine().ToLower();
			if (finalAnswer == "y")
			{
				Menu.DisplayMenu();
			}
			else if (finalAnswer == "n")
			{
				Console.WriteLine("Have a great day!");
				Environment.Exit(1);
			}
        }//
    }
}

