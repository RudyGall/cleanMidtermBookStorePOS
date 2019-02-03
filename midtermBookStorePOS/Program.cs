using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermBookStorePOS
{
    class Program
    {
		static double grandTotal;
		public static List<Book> Cart = new List<Book>();

		static void Main(string[] args)
        {
			

			Menu.DisplayMenu();
            Checkout.PaymentChoice(grandTotal);
            Receipt.PrintReceipt();

            

        }
        
    }
}           
