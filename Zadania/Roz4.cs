using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniaPO.Zadania
{
    internal class Roz4
    {
        static public void menu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("###\tRozdział 4\t###");
                Console.WriteLine("\t1. Zadanie 4.1.");
                Console.WriteLine("\t2. Zadanie 4.2.");
                Console.WriteLine("\t3. Zadanie 4.3.");
                Console.WriteLine("\t4. Zadanie 4.4.");
                Console.WriteLine("\t5. Zadanie 4.5.");
                Console.WriteLine("\t6. Zadanie 4.6.");
                Console.WriteLine("\t7. Zadanie 4.7.");
                Console.WriteLine("\t8. Zadanie 4.8.");
                Console.WriteLine("\t9. Zadanie 4.9.");
                Console.WriteLine("\t10. Zadanie 4.10.");
                Console.WriteLine("\t11. Zadanie 4.11.");
                Console.WriteLine("\t12. Zadanie 4.12.");
                Console.WriteLine("\t14. Zadanie 4.13.");
                Console.WriteLine("\t14. Zadanie 4.14.");
                Console.WriteLine("\t15. Zadanie 4.15.");
                Console.WriteLine("\tq. Wyjście.");
                Console.Write("\nWybierz opcję z menu: ");
                string option = Console.ReadLine();
                Console.Clear();
                switch (option)
                {
                    case "1":
                        zad41();
                        break;
                    case "2":
                        zad42();
                        break;
                    case "3":
                        zad43();
                        break;
                    case "4":
                        zad44();
                        break;
                    case "5":
                        zad45();
                        break;
                    case "6":
                        zad46();
                        break;
                    case "7":
                        zad47();
                        break;
                    case "8":
                        zad48();
                        break;
                    case "9":
                        zad49();
                        break;
                    case "10":
                        zad410();
                        break;
                    case "11":
                        zad411();
                        break;
                    case "12":
                        zad412();
                        break;
                    case "13":
                        zad413();
                        break;
                    case "14":
                        zad414();
                        break;
                    case "15":
                        zad415();
                        break;
                    case "q":
                        exit = true;
                        break;
                }
                Console.WriteLine("Wciśnij dowolny przycisk żeby kontynuować.");
                Console.ReadKey();
            }
        }

        private static void zad415()
        {

        }

        private static void zad414()
        {

        }

        private static void zad413()
        {

        }

        private static void zad412()
        {

        }

        private static void zad411()
        {

        }

        private static void zad410()
        {

        }

        private static void zad49()
        {

        }

        private static void zad48()
        {

        }

        private static void zad47()
        {

        }

        private static void zad46()
        {

        }

        private static void zad45()
        {

        }

        private static void zad44()
        {

        }

        private static void zad43()
        {

        }

        private static void zad42()
        {
            Random rand = new Random();
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                arr1[i] = rand.Next(-1000, 1000);
            }
            Console.WriteLine("Wartości tablicy arr1:");
            Output.displayArr(arr1);

            int idx = 0;
            for (int i = 0; i < 10; i++)
            {
                if (arr1[i] > 0)
                {
                    arr2[idx] = arr1[i];
                    idx++;
                }
            }

            Console.WriteLine("Wartości tablicy arr2:");
            Output.displayArr(arr2);
        }

        private static void zad41()
        {
            Console.WriteLine("Wprowadź ile elementów ma zawierać tablica:");
            int n = Input.inputInt();
            int[] arr = new int[n];

            if (n <= 0) return;
            Console.WriteLine("Wprowadź wartości elementów:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Input.inputInt();
            }

            Output.displayArr(arr);
        }
    }
}
