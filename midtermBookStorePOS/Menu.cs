using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermBookStorePOS
{

    class Menu
    {                           //Rudy-Add descriptions of books

        public double Price { get; internal set; }
        

        public static void DisplayMenu()
        {
            List<Book> Books = new List<Book>();
            Book InSearchofLostTime = new Book("In Search of Lost Time", "Marcel Proust", 22.75, 0);
            Books.Add(InSearchofLostTime);
            Book DonQuixote = new Book("Don Quixote", "Miguel de Cervantes", 29.99, 0);
            Books.Add(DonQuixote);
            Book Ulysses = new Book("Ulysses", "James Joyce", 15.95, 0);
            Books.Add(Ulysses);
            Book TheGreatGatsby = new Book("The Great Gatsby", "F.Scott Fitzgerald", 10.82, 0);
            Books.Add(TheGreatGatsby);
            Book MobyDick = new Book("Moby Dick", "Herman Melville", 9.56, 0);
            Books.Add(MobyDick);
            Book Hamlet = new Book("Hamlet", "William Shakespeare", 12.95, 0);
            Books.Add(Hamlet);
            Book WarandPeace = new Book("War and Peace", "Leo Tolstoy", 11.16, 0);
            Books.Add(WarandPeace);
            Book TheOdyssey = new Book("The Odyssey", "Homer", 14.39, 0);
            Books.Add(TheOdyssey);
            Book Lolita = new Book("Lolita", "Vladimir Nabokov", 17.00, 0);
            Books.Add(Lolita);
            Book OntheRoad = new Book("On the Road", "Jack Kerouac", 14.45, 0);
            Books.Add(OntheRoad);
            Book Breakfastofchampions = new Book("Breakfast of champions", "Kurt Vonnegut", 15.35, 0);
            Books.Add(Breakfastofchampions);
            Book TheAlchemist = new Book("The Alchemist", "Paulo Coelho", 13.89, 0);
            Books.Add(TheAlchemist);

			int quantity = 0;
			Checkout c = new Checkout(quantity);

            

            Console.WriteLine("Please choose a number of the following options:\n");
			int num = 1;
			for (int i = 0; i < Books.Count; i++)
			{
				Console.WriteLine(num + ". " + Books[i].Title);
				num++;
			}
			bool toMenu = true;
			while (toMenu == true)
			{
				Console.WriteLine("\nPlease enter a menu number");
				int.TryParse(Console.ReadLine(), out int userNumSelectMenu);
				if (userNumSelectMenu > 0 && userNumSelectMenu <= Books.Count)
				{
					Console.WriteLine("Title: " + Books[userNumSelectMenu - 1].Title);
					Console.WriteLine("Author: " + Books[userNumSelectMenu - 1].Author);
					Console.WriteLine("$" + Books[userNumSelectMenu - 1].Price);
					Console.WriteLine("Please input the amount of books you'd like to order.");
					quantity = int.Parse(Console.ReadLine());
				
					Program.Cart.Add(Books[userNumSelectMenu -1]);					
                }	
                toMenu = backToMenu();
            }
            
        }
        public static bool backToMenu()
        {
            Console.WriteLine("\nWould you like to return to the Menu or proceed to Checkout?(Menu or Checkout)");
            string input = Console.ReadLine().ToLower();
            input = input.ToLower();
            bool goOn;
            if (input == "menu")
            {
                goOn = true;
                DisplayMenu();
            }
            else if (input == "checkout")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = backToMenu();
            }
            return goOn;
        }
    }
}