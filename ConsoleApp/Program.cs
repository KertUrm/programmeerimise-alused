using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp15555
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            bool a = true;
            while (a)
            {
                Console.WriteLine("sisesta nimi");
                string name = Console.ReadLine();
                if (name != "")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Tere, " + name + " !");
                    Console.ForegroundColor = ConsoleColor.White;
                    a = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nime ei sisestatud.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Proovi uuesti.");
                }
            }
            int n1 = 0, n2 = 1, n3;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            while (n1 < 100)
            { 
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
