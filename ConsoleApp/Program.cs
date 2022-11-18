using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kui kaugel sa elad kilomeetrites");
            string kaugus = Console.ReadLine();
            double kaugusConverted = Convert.ToDouble(kaugus);

            if (kaugusConverted <= 10 && kaugusConverted >= 0)
            {
                Console.WriteLine("0 kuni 10");
            }
            else if (kaugusConverted <= 30 && kaugusConverted >= 11)
            {
                Console.WriteLine("11 kuni 30");
            }
            else if (kaugusConverted <= 50 && kaugusConverted >= 31)
            {
                Console.WriteLine("31 kuni 50");
            }
            else if (kaugusConverted <= 90 && kaugusConverted >= 51)
            {
                Console.WriteLine("51 kuni 90");
            }
            else if (kaugusConverted >= 91)
            {
                Console.WriteLine("Suurem või vördne 91");
        }
    }
}
