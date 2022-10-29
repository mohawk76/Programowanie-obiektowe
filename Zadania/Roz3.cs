using System;

namespace ZadaniaPO.Zadania
{
    internal class Roz3
    {
        static public void menu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("###\tRozdział 3\t###");
                Console.WriteLine("\t1. Zadanie 3.1.");
                Console.WriteLine("\t2. Zadanie 3.2.");
                Console.WriteLine("\t3. Zadanie 3.3.");
                Console.WriteLine("\t4. Zadanie 3.4.");
                Console.WriteLine("\t5. Zadanie 3.5.");
                Console.WriteLine("\t6. Zadanie 3.6.");
                Console.WriteLine("\t7. Zadanie 3.7.");
                Console.WriteLine("\t8. Zadanie 3.8.");
                Console.WriteLine("\t9. Zadanie 3.9.");
                Console.WriteLine("\t10. Zadanie 3.10.");
                Console.WriteLine("\t11. Zadanie 3.11.");
                Console.WriteLine("\t12. Zadanie 3.12.");
                Console.WriteLine("\t13. Zadanie 3.13.");
                Console.WriteLine("\t14. Zadanie 3.14.");
                Console.WriteLine("\t15. Zadanie 3.15.");
                Console.WriteLine("\tq. Wyjście.");
                Console.Write("\nWybierz opcję z menu: ");
                string option = Console.ReadLine();
                Console.Clear();
                switch (option)
                {
                    case "1":
                        zad31();
                        break;
                    case "2":
                        zad32();
                        break;
                    case "3":
                        zad33();
                        break;
                    case "4":
                        zad34();
                        break;
                    case "5":
                        zad35();
                        break;
                    case "6":
                        zad36();
                        break;
                    case "7":
                        zad37();
                        break;
                    case "8":
                        zad38();
                        break;
                    case "9":
                        zad39();
                        break;
                    case "10":
                        zad310();
                        break;
                    case "11":
                        zad311();
                        break;
                    case "12":
                        zad312();
                        break;
                    case "13":
                        zad313();
                        break;
                    case "14":
                        zad314();
                        break;
                    case "15":
                        zad315();
                        break;
                    case "q":
                        exit = true;
                        break;
                }
                Console.WriteLine("Wciśnij dowolny przycisk żeby kontynuować.");
                Console.ReadKey();
            }
        }
        static public void zad31()
        {
            Console.Write("Wprowadź rok: ");
            int year = Input.inputInt();
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine("Podany rok jest przestępny");
            }
            else
            {
                Console.WriteLine("Podany rok nie jest przestępny");
            }
        }

        static public void zad32()
        {
            Console.Write("Wprowadź dwie liczby całkowite: ");
            int a = Input.inputInt();
            int b = Input.inputInt();
            if (a % b == 0)
            {
                Console.WriteLine("Druga liczba jest dzielnikiem pierwszej");
            }
            else
            {
                Console.WriteLine("Druga liczba nie jest dzielnikiem pierwszej");
            }
        }

        static public void zad33()
        {
            Console.Write("Wprowadź trzy liczby: ");
            float a = Input.inputFloat();
            float b = Input.inputFloat();
            float c = Input.inputFloat();
            float max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;

            Console.WriteLine($"Maksymalna wprowadzona wartość wynosi: {max}");
        }

        static public void zad34()
        {
            Console.Write("Wprowadź dwie liczby: ");
            double a = Input.inputDouble();
            double b = Input.inputDouble();
            Console.Write("Wprowadź jedną z dostępnych operacji (+, -, *, /): ");
            char op = (char)Console.Read();
            double result = 0;
            switch (op)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("Podano nieprawidłową operacje");
                    return;
            }
            Console.WriteLine($"Wynik działania to: {result}");
        }

        static public void zad35()
        {
            Console.WriteLine("Wprowadź współczynniki a, b i c:");
            float a = Input.inputFloat();
            float b = Input.inputFloat();
            float c = Input.inputFloat();
            float delta = (float)(Math.Pow(b, 2) - 4 * a * c);
            if (delta < 0)
            {
                Console.WriteLine("Równanie nie posiada pierwiastków");
            }
            else if (delta > 0)
            {
                Console.WriteLine("Równanie posiada dwa pierwiastki");
            }
            else
            {
                Console.WriteLine("Równanie posiada jeden pierwiastek");
            }
        }

        static public void zad36()
        {
            Console.Write("Podaj swoją wagę w kg: ");
            float weight = Input.inputFloat();
            Console.Write("Podaj swój wzrost w m: ");
            float height = Input.inputFloat();
            float bmi = (float)(weight / Math.Pow(height, 2));

            if (bmi < 16f)
            {
                Console.WriteLine("Wygłodzenie");
            }
            else if (16f <= bmi && bmi < 17f)
            {
                Console.WriteLine("Wychudzenie");
            }
            else if (17f <= bmi && bmi < 18.5f)
            {
                Console.WriteLine("Niedowaga");
            }
            else if (18.5f <= bmi && bmi < 25f)
            {
                Console.WriteLine("Pożądana masa ciała");
            }
            else if (25f <= bmi && bmi < 30f)
            {
                Console.WriteLine("Nadwaga");
            }
            else if (30f <= bmi && bmi < 35f)
            {
                Console.WriteLine("Otyłość I stopnia");
            }
            else if (35f <= bmi && bmi < 40f)
            {
                Console.WriteLine("Otyłość II stopnia");
            }
            else
            {
                Console.WriteLine("Otyłość III stopnia");
            }
        }

        static public void zad37()
        {
            Console.WriteLine("Wpisz nr dnia tygodnia");
            string numer = Console.ReadLine();

            switch (numer)
            {
                case "1":
                    Console.WriteLine("Poniedziałek");
                    break;
                case "2":
                    Console.WriteLine("Wtorek");
                    break;
                case "3":
                    Console.WriteLine("Środa");
                    break;
                case "4":
                    Console.WriteLine("Czwartek");
                    break;
                case "5":
                    Console.WriteLine("Piątek");
                    break;
                case "6":
                    Console.WriteLine("Sobota");
                    break;
                case "7":
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego dnia tygodnia");
                    break;
            }
        }

        static public void zad38()
        {
            Console.WriteLine("Wprowadź swoją średnią:");
            float avg = Input.inputFloat();
            if (2f <= avg && avg < 4f)
            {
                Console.WriteLine("Przysługuje ci stypednium w kwocie: 0,00 zł");
            }
            else if (4f <= avg && avg < 4.8f)
            {
                Console.WriteLine("Przysługuje ci stypednium w kwocie: 350,00 zł");
            }
            else if (4.8f <= avg && avg <= 5f)
            {
                Console.WriteLine("Przysługuje ci stypednium w kwocie: 550,00 zł");
            }
            else
            {
                Console.WriteLine("Wprowadziłeś błędną średnią");
            }
        }

        static public void zad39()
        {
            Console.Write("Wybierz wariant programu (a, b, c, d): ");
            char option = (char)Console.Read();
            switch (option)
            {
                case 'a':
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < i + 1; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    break;
                case 'b':
                    for (int i = 5; i > 0; i--)
                    {
                        for (int j = 0; j < i - 1; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    break;
                case 'c':
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (j >= (4 - (i + 1)))
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }
                        Console.Write("\n");
                    }
                    break;
                case 'd':
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if ((j == 1 || j == 2) && (i != 0 && i != 3))
                                Console.Write(" ");
                            else
                                Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    break;
                default:
                    Console.WriteLine("Wybrano nieprawidłową opcję!");
                    break;
            }
        }

        static public void zad310()
        {
            Console.WriteLine("Wprowadź n:");
            int n = Input.inputInt();
            long silnia = 1;
            for (int i = 2; i <= n; i++)
            {
                silnia *= i;
            }
            Console.WriteLine($"Silnia z {n} wynosi {silnia}!");
        }

        static public void zad311()
        {
            int number = 1;
            int sum = 0;
            while (sum <= 100)
            {
                sum += number;
                number++;
            }

            Console.WriteLine($"Żeby suma przekroczyła 100, należy dodać do siebie {number} liczby");
        }

        static public void zad312()
        {
            Console.WriteLine("Wprowadzaj liczby całkowite by je zsumować, aby wyświetlić wynik wprowadź 0:");
            int sum = 0;
            int number = Input.inputInt();
            while (number != 0)
            {
                sum += number;
                number = Input.inputInt();
            }
            Console.WriteLine($"Suma wprowadzonych licz to {sum}");
        }

        static public void zad313()
        {
            Console.WriteLine("Wprowadź n:");
            int n = Input.inputInt();
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    result -= i;
                else
                    result += i;
            }
            Console.WriteLine($"Wynik to {result}");
        }

        static public void zad314()
        {
            Console.WriteLine("Wprowadź n:");
            int n = Input.inputInt();

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum += j;
                }
                if (i == sum)
                    Console.WriteLine($"Liczba {i} jest doskonała");
            }
        }

        static public void zad315()
        {
            for (int i = 0; i <= 10; i++)
                for (int j = 0; j <= 5; j++)
                    for (int k = 0; k <= 2; k++)
                        if (i * 1 + j * 2 + k * 5 == 10)
                            Console.WriteLine($"1 zł = {i}, 2 zł = {j}, 5 zł = {k}");

        }
    }
}