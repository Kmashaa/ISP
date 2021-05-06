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
            List<Sportsman> sportsmans = new List<Sportsman>
            {
                new Runner("ivan", "ivanov", "21", "man", "sportsman", "900", "8/10", 80, "170", 40, "no"),
                new Footballer("sasha", "sidorov", "24", "man", "sportsman", "1200", "7/10", 75, "175", 100, 50),
                new Biathlonist("darya", "sviridova", "26", "woman","sportsman", "1000", "9/10", 55, "165", "7/10", "15")

            };
            foreach(var sportsm in sportsmans)
            {
                sportsm.Information();
                sportsm.ParticipInComp();
                sportsm.Information();
            }

        }
    }
}
