using System;

// Получить текущее время и дату в двух разных форматах и вывести на экран коли-чество нулей, единиц, …, девяток в их записи.

namespace _2._1
{
    class Program
    {
        static void Checking(string format)
        {
            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < format.Length; j++)
                {
                    if (format[j] == ((char)(i + 48)))
                    {
                        counter++;
                    }
                }
                Console.Write(((char)(i + 48)) + "-" + counter + "     ");
                counter = 0;
            }
        } 
        static void Main()
        {
            DateTime now = DateTime.Now;
            string firstFormat = now.ToString("F");
            string secondFormat = now.ToString("G");
           
            Checking(firstFormat);
            Console.WriteLine(firstFormat);

            Checking(secondFormat);
            Console.WriteLine(secondFormat);
        }
    }
}
