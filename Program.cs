using System;

namespace ClothesShop
{
    class Program
    {
        static void Main(string[] args)
        {
            User jame = new User("Jame Watson", "jame@gmail.com", "131/75 Putthamonthon", "NakornPathom", "10180");

            jame.AddOrder("L", "Red", 500);
            jame.AddOrder("M", "Black", 750);
            jame.AddOrder("S", "White", 625);

            Console.WriteLine("Client Name: {0}, Email: {1}", jame.GetName(), jame.GetEmail());
            Console.WriteLine("Orders:");
            jame.Orders();
            Console.WriteLine("Total Price = {0}", jame.Total());
        }
    }
}
