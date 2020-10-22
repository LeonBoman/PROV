using System;

namespace code
{//ANDReAS MÄSTERVÄRK
    class Program
    {
        static void Main(string[] args)
        {
            //skapar instanser
            item item = new item();
            customer buyer = new customer();

            //lite filler och skapar buyers
            Console.WriteLine("How many customers do you want?");
            buyer.buyerSay = Console.ReadLine();
            //konverterar string till int
            bool success = int.TryParse(buyer.buyerSay, out buyer.buyerAmount);
            //lägger till i listan
            buyer.buyers.Add(buyer.buyerAmount);
            Console.WriteLine("You added " + buyer.buyerAmount + " buyers.");
            Console.ReadLine();

            Console.WriteLine("Welcome To The Antique Shop.");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Get started by spawning a book.");
            Console.WriteLine("(spawnbook)");
            string action = Console.ReadLine();
            //väldigt snygg kod skapad av mig :)
            while(action != "spawnbook")
            {
                Console.WriteLine("try to write 'spawnbook'");
                action = Console.ReadLine();
            }
            Console.WriteLine("A new book has been spawned!");
            Console.WriteLine("(printinfo)");
            action = Console.ReadLine();
            while(action != "printinfo")
            {
                Console.WriteLine("try to write 'printinfo'");
                action = Console.ReadLine();
            }
            //använder randomizer för att välja ordningar i arrayer
            Console.WriteLine("Name: " + item.name[item.nameArrayNumber]);
            Console.WriteLine("Rarity: " + item.rarityText[item.rarity]);
            Console.WriteLine("Category: " + item.category[item.categoryArrayNumber]);
            Console.WriteLine("Price: " + item.price);
            Console.ReadLine();
        }
    }
}
