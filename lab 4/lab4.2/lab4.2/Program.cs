using System;
using System.Runtime.InteropServices;

namespace ConsoleApp3
{
    class Program
    {
        [DllImport("Dll3.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int DiffOf2Nums(int a, int b);

        [DllImport("Dll3.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int SumOf2Nums(int a, int b);

        static string CheckData(string str, int a, int b)
        {
            int count = 0;
            while (count != str.Length)
            {
                count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= a && str[i] <= b)
                    {
                        count++;
                    }
                }
                if (count != str.Length)
                {
                    Console.WriteLine($"{str} - invalid data. Try again");
                    str = Console.ReadLine();
                }
            }
            return str;
        }

        static void Main()
        {
            Console.WriteLine("Enter the first number");
            string sa = Console.ReadLine();
            int a = Convert.ToInt32(CheckData(sa, 48, 57));
            Console.WriteLine("Enter the second number");
            string sb = Console.ReadLine();
            int b = Convert.ToInt32(CheckData(sb, 48, 57));
            Console.Write("The difference of " + a + " and " + b + " is " + DiffOf2Nums(a, b) + "\n");
            Console.Write("The sum of " + a + " and " + b + " is " + SumOf2Nums(a, b) + "\n");

        }
    }
}
