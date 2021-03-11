using System;

// Получить текущее время и дату в двух разных форматах и вывести на экран коли-чество нулей, единиц, …, девяток в их записи.

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstFormat, secondFormat;
            DateTime now = DateTime.Now;
            firstFormat = now.ToString("F");
            secondFormat = now.ToString("G");
            int counter=0;
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < firstFormat.Length; j++)
                {
                    if (firstFormat[j] == ((char)(i+48)))
                    {
                        counter++;
                    }
                }
                Console.Write(((char)(i + 48)) + "-" + counter + "     ");
                counter = 0;
            }
            Console.WriteLine(firstFormat);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < secondFormat.Length; j++)
                {
                    if (secondFormat[j] == ((char)(i + 48)))
                    {
                        counter++;
                    }
                }
                Console.Write(((char)(i + 48)) + "-"+counter  +  "     ");
                counter = 0;
            }
            Console.WriteLine(secondFormat);
        }
    }
}
