using System;

namespace lab1
{
    class Program
    {
        static void Fifty(int rig,string rigg, string first, string second, string third, string fourth){
            int any;
            any= Rand(rig);
            if (any > rig)
            {
                Console.WriteLine(rigg);
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
            if (any < rig)
            {
                Console.WriteLine(rigg);
            }
        }
        static void Hall(string rigg) 
        {
            Console.WriteLine(rigg);
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
            
            while (choise != "1" && choise != "2" && choise != "3" && choise != "4" && choise != "50" && choise != "hall")
            {
                Console.WriteLine("Error.Write possible answer or hint");
                choise = Console.ReadLine();
            }
            return choise;
        }
        static void Main()
        {
            int score = 100;
            Console.WriteLine("Hello. It's a game: Who wants to be a millionaire?\t");
            string choise;
            int right;
            string rightt;
            string first, second, third, fourth;
                Console.WriteLine("In this game you will have 2 hints:1.50/50 and 2.hall help. If you want to you any of them write 50 or hall");
                first = "1. 0.25 sq. cm";
                second = "2. 0.5 sq. cm";
                third = "3. 0.25 sq. m";
                fourth = "4. 1 sq. cm";
                Console.WriteLine("The first question:\n What area has a standard cell of a notebook?\n "+first+"\n "+second+"\n "+third+"\n "+fourth);
                right = 1;
                rightt = first;
                
                choise = Console.ReadLine();
            choise = Check(choise);
                //while (choise !="1" && choise != "2" && choise != "3" && choise != "4" && choise != "50" && choise != "hall") {
                //    Console.WriteLine("Error.Write possible answer or hint");
                //    choise = Console.ReadLine(); }
            
                if (choise == "50" || choise == "hall")
                {
                    if (choise == "50")
                    {
                        Fifty(right, rightt, first, second, third, fourth);
                        score = score / 4 * 3;
                        choise = Console.ReadLine();
                    while (choise != "1" && choise != "2" && choise != "3" && choise != "4")
                    {
                        Console.WriteLine("Error.Write possible answer");
                        choise = Console.ReadLine();
                    }
                }
                    else { 
                        Hall(rightt); 
                        score /= 2;
                        choise = Console.ReadLine();
                    while (choise != "1" && choise != "2" && choise != "3" && choise != "4")
                    {
                        Console.WriteLine("Error.Write possible answer");
                        choise = Console.ReadLine();
                    }
                }
                }
                switch(choise)
                {
                case "1":
                        score *=2;
                        Console.WriteLine("Great!Now you have " + score+"points") ;
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
                right = 2;
                rightt = second;
                Console.WriteLine("The second question:\n What gas is dominant in the Earth's atmosphere?\n "+first+"\n "+second+"\n "+third+"\n "+ fourth);
                choise = Console.ReadLine();
            while (choise != "1" && choise != "2" && choise != "3" && choise != "4" && choise != "50" && choise != "hall")
            {
                Console.WriteLine("Error.Write possible answer or hint");
                choise = Console.ReadLine();
            }
            if (choise == "50" || choise == "hall")
                {
                    if (choise == "50")
                    {
                        Fifty(right, rightt, first, second, third, fourth);
                        score = score / 4 * 3;
                        choise = Console.ReadLine();
                    while (choise != "1" && choise != "2" && choise != "3" && choise != "4")
                    {
                        Console.WriteLine("Error.Write possible answer");
                        choise = Console.ReadLine();
                    }
                }
                    else { 
                        Hall(rightt);
                        score /= 2;
                        choise = Console.ReadLine();
                    while (choise != "1" && choise != "2" && choise != "3" && choise != "4")
                    {
                        Console.WriteLine("Error.Write possible answer");
                        choise = Console.ReadLine();
                    }
                }
                }
                switch (choise)
                {
                    case "2":
                        score *=2;
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
                right = 3;
                rightt = third;
                Console.WriteLine("The third question:\n The sea route to which country was Columbus's expedition looking for, having sailed instead to America?\n " + first + "\n " + second + "\n " + third + "\n " + fourth);
                choise = Console.ReadLine();
            while (choise != "1" && choise != "2" && choise != "3" && choise != "4" && choise != "50" && choise != "hall")
            {
                Console.WriteLine("Error.Write possible answer or hint");
                choise = Console.ReadLine();
            }
            if (choise == "50" || choise == "hall")
                {
                    if (choise == "50")
                    {
                        Fifty(right, rightt, first, second, third, fourth);
                        score = score / 4 * 3;
                        choise = Console.ReadLine();
                    while (choise != "1" && choise != "2" && choise != "3" && choise != "4")
                    {
                        Console.WriteLine("Error.Write possible answer");
                        choise = Console.ReadLine();
                    }
                }
                    else { 
                        Hall(rightt);
                        score /= 2;
                        choise = Console.ReadLine();
                    while (choise != "1" && choise != "2" && choise != "3" && choise != "4")
                    {
                        Console.WriteLine("Error.Write possible answer");
                        choise = Console.ReadLine();
                    }
                }
                }
                switch (choise)
                {
                    case "3":
                        score *=2;
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
                right = 3;
                rightt = third;
                Console.WriteLine("The fourth question:\n What is the name of the only duchy in Europe?\n 1.Monaco\n 2.Andorra\n 3.Luxembourg\n 4.Liechtenstein");
                choise = Console.ReadLine();
            while (choise != "1" && choise != "2" && choise != "3" && choise != "4" && choise != "50" && choise != "hall")
            {
                Console.WriteLine("Error.Write possible answer or hint");
                choise = Console.ReadLine();
            }
            if (choise == "50" || choise == "hall")
                {
                    if (choise == "50")
                    {
                        Fifty(right, rightt, first, second, third, fourth);
                        score = score / 4 * 3;
                        choise = Console.ReadLine();
                    while (choise != "1" && choise != "2" && choise != "3" && choise != "4")
                    {
                        Console.WriteLine("Error.Write possible answer");
                        choise = Console.ReadLine();
                    }
                }
                    else { 
                        Hall(rightt);
                        score /= 2;
                        choise = Console.ReadLine();
                    while (choise != "1" && choise != "2" && choise != "3" && choise != "4")
                    {
                        Console.WriteLine("Error.Write possible answer");
                        choise = Console.ReadLine();
                    }
                }
                }
                switch (choise)
                {
                    case "3":
                        score *=2;
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
                right = 4;
                rightt = fourth;
                Console.WriteLine("The last question:\n Which city in the United States is considered to be the birthplace of jazz?\n 1.Chicago\n 2.New York\n 3.San Francisco\n 4.New Orleans");
                choise = Console.ReadLine();
            while (choise != "1" && choise != "2" && choise != "3" && choise != "4" && choise != "50" && choise != "hall")
            {
                Console.WriteLine("Error.Write possible answer or hint");
                choise = Console.ReadLine();
            }
            if (choise == "50" || choise == "hall")
                {
                    if (choise == "50")
                    {
                        Fifty(right, rightt, first, second, third, fourth);
                        score = score / 4 * 3;
                        choise = Console.ReadLine();
                    while (choise != "1" && choise != "2" && choise != "3" && choise != "4")
                    {
                        Console.WriteLine("Error.Write possible answer");
                        choise = Console.ReadLine();
                    }
                }
                    else {
                        Hall(rightt);
                        score /= 2;
                        choise = Console.ReadLine();
                    while (choise != "1" && choise != "2" && choise != "3" && choise != "4")
                    {
                        Console.WriteLine("Error.Write possible answer");
                        choise = Console.ReadLine();
                    }
                }
                }
                switch (choise)
                {
                    case "4":
                        score *=2;
                        Console.WriteLine("Great! You won!!! Your score is "+score);
                        break;
                    default:
                    Console.WriteLine("You lose");
                    Environment.Exit(0);
                        break;
                }
            
            
        }
    }
}
