using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniaPO
{
    internal class Output
    {
        public static void displayArr<T>(T[] arr)
        {
            if (arr.Length <= 0) return;
            Console.Write($"[{arr[0]}");
            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write($", {arr[i]}");
            }
            Console.WriteLine("]");
        }
    }
}
