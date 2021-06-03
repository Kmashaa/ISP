using System;

namespace Lab7
{
    class Program
    {
        static void Main()
        {
            Fraction num1 = null, num2 = null;
            bool flag = false;
            while (!flag)
            {
                do
                {
                    Console.WriteLine("Enter first fraction\nExamples: 1/2; -0,5; 54");
                    flag = Fraction.TryParse(Console.ReadLine(), out num1);
                } while (!flag);

                do
                {
                    Console.WriteLine("Enter second fraction");
                    flag = Fraction.TryParse(Console.ReadLine(), out num2);
                } while (!flag);
                flag = true;
            }


            Console.WriteLine($"{num1} - {num2} = {num1 - num2} = {(double)(num1 - num2)}");

            Console.WriteLine($"{num1} + {num2} = {num1 + num2} = {(double)(num1 + num2)}");

            Console.WriteLine($"{num1} * {num2} = {num1 * num2} = {(double)(num1 * num2)}");

            Console.WriteLine($"{num1} / {num2} = {num1 / num2} = {(double)(num1 / num2)}");

            Console.WriteLine($"{num1} == {num2} ? {num1 == num2}");

            Console.WriteLine($"{num1} != {num2} ? {num1 != num2}");

            Console.WriteLine($"{num1} < {num2} ? {num1 < num2}");

            Console.WriteLine($"{num1} > {num2} ? {num1 > num2}");

            Console.WriteLine($"{num1} <= {num2} ? {num1 <= num2}");

            Console.WriteLine($"{num1} >= {num2} ? {num1 >= num2}");
        }
    }
}