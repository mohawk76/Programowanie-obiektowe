using System;

namespace ZadaniaPO
{
    internal class Input
    {
        public static int inputInt()
        {
            bool validInput = true;
            int result;
            do
            {
                if (!validInput)
                {
                    Console.WriteLine("Wprowadzono błędne dane, proszę wprowadzić liczbę całkowitą");
                }
                string input = Console.ReadLine();
                validInput = Int32.TryParse(input, out result);
            } while (!validInput);
            return result;
        }
        public static float inputFloat()
        {
            bool validInput = true;
            float result;
            do
            {
                if (!validInput)
                {
                    Console.WriteLine("Wprowadzono błędne dane, proszę wprowadzić liczbę rzeczywistą");
                }
                string input = Console.ReadLine();
                validInput = float.TryParse(input, out result);
            } while (!validInput);
            return result;
        }

        public static double inputDouble()
        {
            bool validInput = true;
            double result;
            do
            {
                if (!validInput)
                {
                    Console.WriteLine("Wprowadzono błędne dane, proszę wprowadzić liczbę rzeczywistą");
                }
                string input = Console.ReadLine();
                validInput = double.TryParse(input, out result);
            } while (!validInput);
            return result;
        }
    }
}
