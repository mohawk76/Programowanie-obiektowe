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
            string[,] dniTygodnia = new string[7, 3];

            dniTygodnia[0, 0] = "poniedzialek";
            dniTygodnia[0, 1] = "monday";
            dniTygodnia[0, 2] = "montag";

            dniTygodnia[1, 0] = "wtorek";
            dniTygodnia[1, 1] = "tuesday";
            dniTygodnia[1, 2] = "dienstag";

            dniTygodnia[2, 0] = "środa";
            dniTygodnia[2, 1] = "wednesday";
            dniTygodnia[2, 2] = "mittwoch";

            dniTygodnia[3, 0] = "czwartek";
            dniTygodnia[3, 1] = "thursday";
            dniTygodnia[3, 2] = "donnerstag";

            dniTygodnia[4, 0] = "piątek";
            dniTygodnia[4, 1] = "friday";
            dniTygodnia[4, 2] = "freitag";

            dniTygodnia[5, 0] = "sobota";
            dniTygodnia[5, 1] = "saturday";
            dniTygodnia[5, 2] = "samstag";

            dniTygodnia[6, 0] = "niedziela";
            dniTygodnia[6, 1] = "sunday";
            dniTygodnia[6, 2] = "sonntag";

            Output.display2DArr(dniTygodnia);
        }

        private static void zad47()
        {
            Random rnd = new Random();
            int[][] arr1 = new int[2][];
            int[][] arr2 = new int[2][];
            for (int i = 0; i < 2; i++)
            {
                arr1[i] = new int[3];
                arr2[i] = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    arr1[i][j] = rnd.Next(1, 10);
                    arr2[i][j] = rnd.Next(1, 10);
                }
            }
            Console.WriteLine("Zawartość tablicy arr1:");
            Output.displayJaggedArr(arr1);
            Console.WriteLine("Zawartość tablicy arr2:");
            Output.displayJaggedArr(arr2);

            int[][] sum = new int[2][];
            for (int i = 0; i < 2; i++)
            {
                sum[i] = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    sum[i][j] = arr2[i][j] + arr1[i][j];
                }
            }

            Console.WriteLine("Wynik zsumowania macierzy arr1 i arr2:");
            Output.displayJaggedArr(sum);
        }

        private static void zad46()
        {
            Random rnd = new Random();
            int[][] arr = new int[5][];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = new int[5];
                for (int j = 0; j < 5; j++)
                    arr[i][j] = rnd.Next(1, 10);
            }
            Output.displayJaggedArr(arr);

            int sum = 0;
            for (int i = 0, j = 0; j < 5; i++, j++)
            {
                sum += arr[i][j];
            }

            Console.WriteLine($"Suma głównej przekątnej wynosi: {sum}");
        }

        private static void zad45()
        {
            int[] arr1 = Enumerable.Range(0, 10).ToArray();
            int[] arr2 = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[(i + 1) % arr1.Length] = arr1[i];
            }
            Console.WriteLine("Zawartość tablicy arr1:");
            Output.displayArr(arr1);
            Console.WriteLine("Zawartość skopiowanej tablicy arr2:");
            Output.displayArr(arr2);
        }

        private static void zad44()
        {
            Random rand = new Random();
            int[] arr1 = new int[100];

            for (int i = 0; i < 100; i++)
            {
                arr1[i] = rand.Next(0, 1000);
            }

            Func<int, bool> isPrime = (val) =>
            {
                if (val < 2) return false;
                int valSqrt = (int)Math.Sqrt(val);
                for (int i = 2; i < valSqrt; i++)
                {
                    if (val % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            };

            Console.WriteLine("Wartości tablicy:\n");
            Output.displayArr(arr1);

            Console.WriteLine($"Ilość liczb pierwszych w tablicy: {arr1.Count(isPrime)}");
        }

        private static void zad43()
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

            Func<int[], int> max = (values) =>
            {
                if (values.Length == 0) return -1;
                int idx = 0;
                for (int i = 1; i < values.Length; i++)
                {
                    if (values[i] > values[idx])
                    {
                        idx = i;
                    }
                }
                return idx;
            };

            Func<int[], int> min = (values) =>
            {
                if (values.Length == 0) return -1;
                int idx = 0;
                for (int i = 1; i < values.Length; i++)
                {
                    if (values[i] < values[idx])
                    {
                        idx = i;
                    }
                }
                return idx;
            };

            Func<int[], float> avg = (values) =>
            {
                if (values.Length == 0) return 0;
                return values.Sum() / (float)values.Length;
            };

            Func<int[], int> countPositive = (values) =>
            {
                int counter = 0;
                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i] > 0)
                    {
                        counter++;
                    }
                }
                return counter;
            };

            int maxIdx = max(arr);
            int minIdx = min(arr);
            float avgVal = avg(arr);
            int positives = countPositive(arr);
            Console.WriteLine($"Największy element: [{maxIdx}] => {arr[maxIdx]}");
            Console.WriteLine($"Najmniejszt element: [{minIdx}] => {arr[minIdx]}");
            Console.WriteLine($"Średnia wartość: {avgVal}");
            Console.WriteLine($"Ilość liczb pozytywnych: {positives}");
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
