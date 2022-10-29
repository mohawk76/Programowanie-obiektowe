using System;
using ZadaniaPO.Zadania;

namespace ZadaniaPO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static public void menu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("###\tLista rozdziałów\t###");
                Console.WriteLine("\t1. Rozdział 2.");
                Console.WriteLine("\t2. Rozdział 3.");
                Console.WriteLine("\tq. Wyjście.");
                Console.Write("\nWybierz opcję z menu: ");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Roz2.menu();
                        break;
                    case "2":
                        Roz3.menu();
                        break;
                    case "q":
                        exit = true;
                        break;
                }
            };
        }
    }
}
