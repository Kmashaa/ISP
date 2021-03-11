using System;

//Рассчитать максимальную степень двойки, на которую делится произведение под-ряд идущих чисел от a до b (числа целые 64-битные без знака).
namespace _2._3
{
    class Program
    {
        static ulong Check( string numberString)
        {
            ulong numberULong;
            while (!ulong.TryParse(numberString, out numberULong))
            {
                Console.WriteLine("Error. Write a number");
                numberString = Console.ReadLine();
            }
            return numberULong;
        }
        static ulong Counting(ulong number1ULong)
        {
            ulong res1=0;
            while (number1ULong > 0)
            {
                number1ULong /= 2;
                res1 += number1ULong;
            }
            return res1;
        }
        static void Main()
        {
            Console.WriteLine("You will need to enter 2 integers:a and b (a<b)\n");

            Console.WriteLine("Enter the first number(a)");
            string number1String = Console.ReadLine();
            ulong number1ULong = Check(number1String);

            Console.WriteLine("Enter the second number(b)");
            string number2String = Console.ReadLine();
            ulong number2ULong = Check(number2String);
           
            if (number1ULong > number2ULong)
            {
                ulong number = number1ULong;
                number1ULong = number2ULong;
                number2ULong = number;
                Console.WriteLine("Your entered 'a' was bigger than 'b'. " +
                                  "They will be swaped. Now a = " + number1ULong +
                                  ", b = " + number2ULong);
            }

            ulong result;
            if (number1ULong == 0 || number2ULong == 0)
            {
                result = 0;
                Console.WriteLine(result);
                Environment.Exit(0);
            }

            if (number1ULong % 2 == 0)
            {
                number1ULong -= 1;
            }

            ulong res1;
            res1 = Counting(number1ULong);

            ulong res2;
            res2 = Counting(number2ULong);

            result = res2 - res1;
            Console.WriteLine(result);

        }
    }
}
