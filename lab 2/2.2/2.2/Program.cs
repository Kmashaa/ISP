using System;
//Дана строка. Записать номера символов, входящих в нее, в виде шестнадцатерич-ных чисел через пробелы. Числа должны быть ровно из четырех цифр (возможно, с нулями в начале).
namespace _2._2
{
    class Program
    {
        static void Main()
        {
            string text;
            text = Console.ReadLine();
            int len = text.Length;
                char[] values = text.ToCharArray();
               for(int i=0;i<len;i++) 
               {   int value = Convert.ToInt32(values[i]);
                string numHex = $"{value:X}";
                if (numHex.Length < 4)
                {
                    do
                    {
                        numHex=numHex.Insert(0, "0");
                    } while (numHex.Length < 4);
                }
                    Console.Write(numHex+" ");
               }            
        }
    }
}
