using Run;
using Biathlon;
using Football;
using Sport;
using System.Collections.Generic;


namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Runner Ivan = new Runner("ivan", "ivanov", "21", "man", "sportsman", "900", "8/10", 80, "170", 40, "no");
            Footballer Sasha = new Footballer("sasha", "sidorov", "24", "man", "sportsman", "1200", "7/10", 75, "175", 100, 50);
            Biathlonist Darya = new Biathlonist("darya", "sviridova", "26", "woman", "sportsman", "1000", "9/10", 55, "165", "7/10", "15");
            Biathlonist Petya = new Biathlonist("petya", "petrov", "26", "man", "sportsman", "900", "9/10", 80, "180", "7/10", "15");
            List<Sportsman> sportsmans = new List<Sportsman>
            {
                Ivan,
                Sasha,
                Darya
            };

            foreach(var sportsm in sportsmans)
            {
                sportsm.Information();
                sportsm.ParticipInComp();
                sportsm.Information();
            }
            Sasha.GainWeight();
            Runner Ivan2 = (Runner)Ivan.Clone();
            Ivan2.Information();

            List<Biathlonist> people = new List<Biathlonist>
            {
               Petya,
                Darya
            };
            people.Sort();
            foreach (var p in people)
            {
                p.Information();
                
            }
        }
    }
}
