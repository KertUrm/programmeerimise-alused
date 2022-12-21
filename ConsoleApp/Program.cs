using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<string> nameList = new List<string> { "user1", "user2", "user3" };
            //List<string> passList = new List<string> { "abc", "123", "qwerty" };
            List<string> passList = new List<string> { "ba7816bf8f01cfea414140de5dae2223b00361a396177a9cb410ff61f20015ad", "a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3", "65e84be33532fb784c48129675f9eff3a682b27168c0ea744b2cf58ee02337c5" };

            while (true)
            {
                Console.Clear();

                Console.WriteLine("1=login, 2=register, 3=delete");
                string answer = Console.ReadLine();

                if (answer == "1")
                {
                    Console.Clear();
                    Console.Write("Name: ");
                    string nameInput = Console.ReadLine();

                    if (nameList.Contains(nameInput))
                    {
                        Console.Write("Pass: ");
                        string passInput = Console.ReadLine();

                        if (passList.IndexOf(ComputeSha256Hash(passInput)) == nameList.IndexOf(nameInput))
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("1=house, 2=triangle, 3=diamond, 4=sqaure, 5=int to binary");
                                string input = Console.ReadLine();
                                Console.Clear();
                                if (input == "1")
                                {
                                    Console.Write("Size: ");
                                    int a = Convert.ToInt32(Console.ReadLine()), b = a;
                                    string c = "", d = "", e = "*", f = "", g = "";
                                    for (int i = 1; i <= a; i++)
                                    {
                                        for (int j = 1; j <= b; j++)
                                        {
                                            c += " ";
                                        }
                                        b--;
                                        Console.WriteLine(c + d + d + e);
                                        d += e;
                                        c = "";
                                    }
                                    for (int i = 1; i <= a * 2 + 1; i++)
                                    {
                                        f += e;
                                    }
                                    for (int i = 1; i <= a; i++)
                                    {
                                        Console.WriteLine(f);
                                    }
                                }
                                else if (input == "2")
                                {
                                    Console.Write("Size: ");
                                    int a = Convert.ToInt32(Console.ReadLine()), b = a;
                                    string c = "", d = "", e = "*", f = "", g = "";
                                    for (int i = 1; i <= a; i++)
                                    {
                                        for (int j = 1; j <= b; j++)
                                        {
                                            c += " ";
                                        }
                                        b--;
                                        Console.WriteLine(c + d + d + e);
                                        d += e;
                                        c = "";
                                    }
                                }
                                else if (input == "3")
                                {
                                    Console.Write("Size: ");
                                    int a = Convert.ToInt32(Console.ReadLine()), b = a;
                                    string c = "", d = "", e = "*", f = "", g = "";
                                    for (int i = 1; i <= a; i++)
                                    {
                                        for (int j = 1; j <= b; j++)
                                        {
                                            c += " ";
                                        }
                                        b--;
                                        Console.WriteLine(c + d + d);
                                        d += e;
                                        c = "";
                                    }
                                    c = ""; d = ""; e = "*"; f = ""; g = ""; b = a;
                                    for (int i = 1; i <= a; i++)
                                    {
                                        for (int j = 1; j <= b; j++)
                                        {
                                            c += e;
                                        }
                                        b--;
                                        Console.WriteLine(d + c + c);
                                        d += " ";
                                        c = "";
                                    }

                                }
                                else if (input == "4")
                                {
                                    Console.Write("Size: ");
                                    int a = Convert.ToInt32(Console.ReadLine()), b = a;
                                    string c = "", d = "", e = "*", f = "", g = "";
                                    for (int i = 1; i <= a; i++)
                                    {
                                        f += e;
                                    }
                                    for (int i = 1; i <= a / 2; i++)
                                    {
                                        Console.WriteLine(f);
                                    }
                                }
                                else if (input == "5")
                                {
                                    Console.Write("Number: ");
                                    int a = Convert.ToInt32(Console.ReadLine()), b = a;
                                    string d = "";

                                    while (b > 0)
                                    {
                                        d += b % 2;
                                        b /= 2;
                                    }
                                    Console.WriteLine("Output: " + Reverse(d));
                                }
                                else
                                {
                                    Console.WriteLine("error");
                                }
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("error");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("error");
                        Console.ReadKey();
                    }
                }
                else if (answer == "2")
                {
                    Console.Clear();

                    Console.Write("Name: ");
                    nameList.Add(Console.ReadLine());

                    Console.Write("Pass: ");
                    passList.Add(ComputeSha256Hash(Console.ReadLine()));

                    Console.ReadKey();
                }
                else if (answer == "3")
                {
                    Console.Clear();
                    Console.Write("Name: ");
                    string nameInput = Console.ReadLine();

                    if (nameList.Contains(nameInput))
                    {
                        Console.Write("Pass: ");
                        string passInput = Console.ReadLine();

                        if (passList.IndexOf(ComputeSha256Hash(passInput)) == nameList.IndexOf(nameInput))
                        {
                            passList.Remove(passInput);
                            nameList.Remove(nameInput);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("error");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("error");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("error");
                    Console.ReadKey();
                }
            }
        }
        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
