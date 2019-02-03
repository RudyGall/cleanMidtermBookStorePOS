using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermBookStorePOS
{
    class Checkout
    {
        public Menu Item { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }//
        public double taxRate = 0.06;//

        public Checkout()
        {
        }

        public Checkout(int quantity)
        {
            Quantity = quantity;
        }

        public double SubTotal()
        {
            double subTotal = Item.Price * Quantity;
            return subTotal;
        }

        public double SalesTaxTotal()
        {
            double subTotal = SubTotal();
            double tax = subTotal * taxRate;
            return tax;
        }

        public double GrandTotal()
        {
            PaymentValidation c = new PaymentValidation();
            double subTotal = SubTotal();
            double tax = SalesTaxTotal();
            double grandTotal = subTotal + tax;
            
            return grandTotal;
        }
        public static void PaymentChoice(double grandTotal)
        {
            //
            bool paymentReturn = true;
            while (paymentReturn == true)
            {
                Console.WriteLine("How will you be paying today? cash, card, or check?");
                string paymentChoice = Console.ReadLine().ToLower();
                if (paymentChoice == "cash")
                {
					paymentReturn = false;
					PaymentValidation.Cash(grandTotal);
					
                }
                else if (paymentChoice == "card")
                {
                    PaymentValidation.Credit();
					paymentReturn = false;
				}
                else if (paymentChoice == "check")
                {
                    PaymentValidation.Check();
					paymentReturn = false;
				}
                else
                    Console.WriteLine("Sorry, I didn't understand, please write 'cash' 'card' or 'check'.");
                paymentReturn = false;
            }
        }
    }
}