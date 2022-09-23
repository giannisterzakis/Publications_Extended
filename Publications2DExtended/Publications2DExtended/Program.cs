using System;

namespace Publications2DExtended
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set Console name and text color
            Console.Title = "Publication2D Extended";
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Display the logo of the console app
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|                   Publication2D Extended in C#                  |");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            CashTill till1 = new CashTill();

            Book book1 = new Book("Software Development", 10.99, 3, "Liz Gandy");
            BulkBook book2 = new BulkBook("Programming in C#", 20.5, 1, "Linda White");

            Magazine mag1 = new Magazine("C# monthly", 2.5, 10, 10, "September");
            DiscMag dmag1 = new DiscMag("C# programming", 2.5, 10, 10, "September");

            Ticket ticket = new Ticket("The Sound of Music", 25.99, "Sunderland Empire");

            StampBook stampbook = new StampBook(6, 30, 180);

            Console.WriteLine(book1.ToString() + " copies left " + book1.Copies);
            Console.WriteLine(book2.ToString() + " copies left " + book2.Copies);
            Console.WriteLine(mag1.ToString() + " copies left " + mag1.Copies);
            Console.WriteLine(dmag1.ToString() + " copies left " + dmag1.Copies);
            Console.WriteLine();

            till1.SellItem(book2);
            till1.SellItem(mag1);
            till1.SellItem(mag1);
            till1.SellItem(ticket);

            till1.ShowTotal();

            Console.WriteLine();
            Console.WriteLine(book1.ToString() + " copies left " + book1.Copies);
            Console.WriteLine(book2.ToString() + " copies left " + book2.Copies);
            Console.WriteLine(mag1.ToString() + " copies left " + mag1.Copies);
            Console.WriteLine(dmag1.ToString() + " copies left " + dmag1.Copies);
            Console.WriteLine();

            till1.SaleType(book2);
            till1.SaleType(mag1);
            till1.SaleType(ticket);
            till1.SellItem(stampbook);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
