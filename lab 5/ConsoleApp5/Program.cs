using Run;
using Biathlon;
using Football;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Person.Human firstPerson = new Person.Human("ivan", "petrov", "25", "man", "sportsman", "800");
            firstPerson.Information();

            Runner secondPerson = new Runner("ivan", "ivanov", "21", "man", "sportsman", "900", "8/10", 80, "170", 40, "no");
            secondPerson.Information();
            secondPerson.GainWeight();
            secondPerson.GainWeight(5);
            secondPerson.NewMaxDistance(50);
            secondPerson.ChangeInformation("petya");
            secondPerson.SetRecord();
            secondPerson.Information();

            Footballer thirdPerson = new Footballer("sasha", "sidorov", "24", "man", "sportsman", "1200", "7/10", 75, "175", 100, 50);
            thirdPerson.Information();
            thirdPerson.MoreConcededGoals(5);
            thirdPerson.MoreScoredGoals();
            thirdPerson.Information();
            
            Biathlonist fourthPerson = new Biathlonist("darya", "sviridova", "26", "woman","sportsman", "1000", "9/10", 55, "165", "7/10", "15");
            fourthPerson.Information();
            fourthPerson.Shoot(1, 1, 0, 1, 1);
            fourthPerson.Information();

        }
    }
}
