using System;

namespace lab1
{
    class Program
    {
        static void Fifty(int rightInt,string rightString, string first, string second, string third, string fourth){
            int any;
            any = Rand(rightInt);
            if (any > rightInt)
            {
                Console.WriteLine(rightString);
            }
                switch (any)
                {
                    case 1:
                        Console.WriteLine(first);
                        break;
                    case 2:
                        Console.WriteLine(second);
                        break;
                    case 3:
                        Console.WriteLine(third);
                        break;
                    case 4:
                        Console.WriteLine(fourth);
                        break;
                }
            if (any < rightInt)
            {
                Console.WriteLine(rightString);
            }
        }

        static void Hall(string rightString) 
        {
            Console.WriteLine(rightString);
        }

        static int Rand(int rig)
        {
            int any = 1;
            Random rnd = new Random();
            while (any == rig)
            {
                any = rnd.Next(1, 5);
            }
            return any;
        }

        static string Check(string choise)
        {
            while (choise != "1" && choise != "2" && choise != "3" &&
                   choise != "4" && choise != "50" && choise != "hall")
            {
                Console.WriteLine("Error. Write possible answer or hint");
                choise = Console.ReadLine();
            }
            return choise;
        }

        static string CheckAnswer(string choise)
        {
            while (choise != "1" && choise != "2" && choise != "3" && choise != "4")
            {
                Console.WriteLine("Error. Write possible answer");
                choise = Console.ReadLine();
            }
            return choise;
        }

        static void Main()
        {
            Console.WriteLine("Hello. It's a game: Who wants to be a millionaire?\t");
            Console.WriteLine("In this game you will have 2 hints:1.50/50 and 2.hall help." +
                              " If you want to use one of them write 50 or hall");

            string first = "1. 0.25 sq. cm";
            string second = "2. 0.5 sq. cm";
            string third = "3. 0.25 sq. m";
            string fourth = "4. 1 sq. cm";
            Console.WriteLine("The first question:\n What area has a standard cell of a notebook?\n "
                                + first + "\n " + second + "\n " + third + "\n " + fourth);
            int rightInt = 1;
            string rightString = first;

            string choise = Console.ReadLine();
            choise = Check(choise);

            int score = 100;
            if (choise == "50" || choise == "hall")
            {
                if (choise == "50")
                {
                    Fifty(rightInt, rightString, first, second, third, fourth);
                    score = score / 4 * 3;
                    choise = Console.ReadLine();
                    choise = CheckAnswer(choise);
                }
                else
                {
                    Hall(rightString);
                    score /= 2;
                    choise = Console.ReadLine();
                    choise = CheckAnswer(choise);
                }
            }
            switch (choise)
            {
                case "1":
                    score *= 2;
                    Console.WriteLine("Great!Now you have " + score + " points");
                    break;
                default:
                    Console.WriteLine("You lose");
                    Environment.Exit(0);
                    break;
            }

            first = "1. Oxygen";
            second = "2. Nitrogen";
            third = "3. Hydrogen";
            fourth = "4. Helium";
            rightInt = 2;
            rightString = second;

            Console.WriteLine("The second question:\n" +
                              "What gas is dominant in the Earth's atmosphere?\n " +
                              first + "\n " + second + "\n " + third + "\n " + fourth);
            choise = Console.ReadLine();
            choise = Check(choise);

            if (choise == "50" || choise == "hall")
            {
                if (choise == "50")
                {
                    Fifty(rightInt, rightString, first, second, third, fourth);
                    score = score / 4 * 3;
                    choise = Console.ReadLine();
                    choise = CheckAnswer(choise);
                }
                else
                {
                    Hall(rightString);
                    score /= 2;
                    choise = Console.ReadLine();
                    choise = CheckAnswer(choise);
                }
            }

            switch (choise)
            {
                case "2":
                    score *= 2;
                    Console.WriteLine("Great!Now you have " + score + " points");
                    break;
                default:
                    Console.WriteLine("You lose");
                    Environment.Exit(0);
                    break;
            }

            first = "1. Ethiopia";
            second = "2. Japan";
            third = "3. India";
            fourth = "4. China";
            rightInt = 3;
            rightString = third;

            Console.WriteLine("The third question:\n " +
                              "The sea route to which country was Columbus's expedition looking for," +
                              " having sailed instead to America?\n " +
                              first + "\n " + second + "\n " + third + "\n " + fourth);
            choise = Console.ReadLine();
            choise = Check(choise);
            if (choise == "50" || choise == "hall")
            {
                if (choise == "50")
                {
                    Fifty(rightInt, rightString, first, second, third, fourth);
                    score = score / 4 * 3;
                    choise = Console.ReadLine();
                    choise = CheckAnswer(choise);
                }
                else
                {
                    Hall(rightString);
                    score /= 2;
                    choise = Console.ReadLine();
                    choise = CheckAnswer(choise);
                }
            }

            switch (choise)
            {
                case "3":
                    score *= 2;
                    Console.WriteLine("Great!Now you have " + score + " points");
                    break;
                default:
                    Console.WriteLine("You lose");
                    Environment.Exit(0);
                    break;
            }

            first = "1. Monaco";
            second = "2. Andorra";
            third = "3. Luxembourg";
            fourth = "4. Liechtenstein";
            rightInt = 3;
            rightString = third;

            Console.WriteLine("The fourth question:\n" +
                              " What is the name of the only duchy in Europe?\n" +
                              " 1.Monaco\n 2.Andorra\n 3.Luxembourg\n 4.Liechtenstein");
            choise = Console.ReadLine();
            choise = Check(choise);
            if (choise == "50" || choise == "hall")
            {
                if (choise == "50")
                {
                    Fifty(rightInt, rightString, first, second, third, fourth);
                    score = score / 4 * 3;
                    choise = Console.ReadLine();
                    choise = CheckAnswer(choise);
                }
                else
                {
                    Hall(rightString);
                    score /= 2;
                    choise = Console.ReadLine();
                    choise = CheckAnswer(choise);
                }
            }

            switch (choise)
            {
                case "3":
                    score *= 2;
                    Console.WriteLine("Great!Now you have " + score + " points");
                    break;
                default:
                    Console.WriteLine("You lose");
                    Environment.Exit(0);
                    break;
            }

            first = "1. Chicago";
            second = "2. New York";
            third = "3. San Francisco";
            fourth = "4. New Orleans";
            rightInt = 4;
            rightString = fourth;

            Console.WriteLine("The last question:\n " +
                              "Which city in the United States is considered to be the birthplace of jazz?\n" +
                              " 1.Chicago\n 2.New York\n 3.San Francisco\n 4.New Orleans");
            choise = Console.ReadLine();
            choise = Check(choise);
            if (choise == "50" || choise == "hall")
            {
                if (choise == "50")
                {
                    Fifty(rightInt, rightString, first, second, third, fourth);
                    score = score / 4 * 3;
                    choise = Console.ReadLine();
                    choise = CheckAnswer(choise);
                }
                else
                {
                    Hall(rightString);
                    score /= 2;
                    choise = Console.ReadLine();
                    choise = CheckAnswer(choise);
                }
            }

            switch (choise)
            {
                case "4":
                    score *= 2;
                    Console.WriteLine("Great! You won!!! Your score is " + score);
                    break;
                default:
                    Console.WriteLine("You lose");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
