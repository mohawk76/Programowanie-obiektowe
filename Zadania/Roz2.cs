using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniaPO.Zadania
{
    internal class Roz2
    {
        static public void menu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("###\tRozdział 2\t###");
                Console.WriteLine("\t1. Zadanie 2.1.");
                Console.WriteLine("\t2. Zadanie 2.2.");
                Console.WriteLine("\t3. Zadanie 2.3.");
                Console.WriteLine("\t4. Zadanie 2.10.");
                Console.WriteLine("\tq. Wyjście.");
                Console.Write("\nWybierz opcję z menu: ");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        zad21();
                        break;
                    case "2":
                        zad22();
                        break;
                    case "3":
                        zad23();
                        break;
                    case "4":
                        zad210();
                        break;
                    case "q":
                        exit = true;
                        break;
                }
            };
        }

        static public void zad21()
        {
            Console.Clear();
            Console.WriteLine("Podaj temperaturę w stopniach celsjusza żeby przeliczyć ją na stopnie Fahrenheita: ");
            float deegres = Input.inputFloat();
            float fahrenheit = 32f + (9f / 5f) * deegres;
            Console.WriteLine("Temperatura w stopniach Fahrenheita wynosi: " + fahrenheit);
            Console.ReadKey();
        }
        static public void zad22()
        {
            Console.Clear();
            Console.Write("Podaj współczynnik a: ");
            float a = Input.inputFloat();
            Console.Write("Podaj współczynnik b: ");
            float b = Input.inputFloat();
            Console.Write("Podaj współczynnik c: ");
            float c = Input.inputFloat();
            Console.WriteLine("Delta wynosi: " + (float)(Math.Pow(b, 2) - 4 * a * c));
            Console.ReadKey();
        }
        static public void zad23()
        {
            Console.Clear();
            Console.Write("Podaj swoją wagę w kg: ");
            float weight = Input.inputFloat();
            Console.Write("Podaj swój wzrost w m: ");
            float height = Input.inputFloat();
            Console.WriteLine("Twoje BMI wynosi: " + (float)(weight / Math.Pow(height, 2)));
            Console.ReadKey();
        }

        static public void zad210()
        {
            Console.Clear();
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = (float)osoby / powierzchnia;
            Console.WriteLine(gestoscZaludnienia);
            Console.ReadKey();
        }
    }
}
