using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniaPO
{
    internal class Output
    {
        public static void displayArr<T>(T[] arr, bool newline = true)
        {
            if (arr.Length <= 0) return;
            Console.Write($"[{arr[0]}");
            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write($", {arr[i]}");
            }
            if (newline) Console.WriteLine("]");
            else Console.Write("]");
        }

        public static void displayJaggedArr<T>(T[][] arr, bool newline = true)
        {
            if (arr.Length <= 0) return;
            Console.WriteLine("[");
            Console.Write("\t");
            displayArr(arr[0], false);
            Console.WriteLine(",");
            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write("\t");
                displayArr(arr[i], false);
                if (i < arr.Length - 1)
                    Console.WriteLine(",");
                else
                    Console.WriteLine();
            }
            if (newline) Console.WriteLine("]");
            else Console.Write("]");
        }

        private static void display2DArrayRow<T>(T[,] arr, int idx)
        {
            Console.Write($"[{arr[idx, 0]}");
            for (int i = 1; i < arr.GetLength(1); i++)
            {
                Console.Write($", {arr[idx, i]}");
            }
            Console.Write("]");
        }

        public static void display2DArr<T>(T[,] arr, bool newline = true)
        {
            if (arr.Length <= 0) return;
            Console.WriteLine("[");
            Console.Write("\t");
            display2DArrayRow(arr, 0);
            Console.WriteLine(",");
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                Console.Write("\t");
                display2DArrayRow(arr, i);
                if (i < arr.GetLength(0) - 1)
                    Console.WriteLine(",");
                else
                    Console.WriteLine();
            }
            if (newline) Console.WriteLine("]");
            else Console.Write("]");
        }
    }
}
