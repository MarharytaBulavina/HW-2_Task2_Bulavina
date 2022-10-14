using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter how many elements you want to have in your array:");
            int elementCount = int.Parse(Console.ReadLine());
            int[] newArray = new int[elementCount];
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine($"Please, enter the array element which index is {i}");
                newArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("This is your array:");
            int b = 0;
            while (b < newArray.Length)
            {
                Console.WriteLine(newArray[b]);
                b++;
            }
            int n = newArray.Length;
            for (int i = 0; i < (n / 2); i++)
            {
                int temp = newArray[i];
                newArray[i] = newArray[newArray.Length - i - 1];
                newArray[newArray.Length - i - 1] = temp;
            }
            Console.WriteLine("This is your swapped array:");
            int c = 0;
            while (c < newArray.Length)
            {
                Console.WriteLine(newArray[c]);
                c++;
            }
        }
    }
}
