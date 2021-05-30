using System;
using Sport;
using ConsoleApp5;

namespace Football
{
    class Footballer : Sportsman, ITrain
    {
        public struct Parameters
        {
            public int Weight;
            public string Height;
        }
        Parameters p;

        protected int _scoredGoals{get; set;}
        protected int _concededGoals { get; set; }

        public Footballer(string name, string surname, string age, string gender, string profession,
                      string salary,string endurance, int weight, string height, int scoredGoals, int concededGoals) :
            base(name, surname, age, gender, profession, salary)
        {
            _endurance = CheckData(endurance, 47, 57);
            p.Weight = weight;
            p.Height = CheckData(height, 48, 57);
            _scoredGoals = scoredGoals;
            _concededGoals = concededGoals;
        }

        public void MoreScoredGoals()
        {
            _scoredGoals++;
        }

        public void MoreScoredGoals(int num)
        {
            _scoredGoals += num;
        }

        public void MoreConcededGoals()
        {
            _concededGoals++;
        }

        public void MoreConcededGoals(int num)
        {
            _concededGoals += num;
        }

       public void GainWeight()
        {
            p.Weight++;
        }
        public override void LoseWeight()
        {
            p.Weight--;
        }

        public override void LoseWeight(int lessWeight)
        {
            p.Weight -= lessWeight;
        }

        public override void ParticipInComp()
        {
            LoseWeight(5);
            MoreConcededGoals(5);
            MoreScoredGoals();
        }

       

        public override void Information()
        {
            Console.WriteLine($"\nName: {_name}\nSurname: {_surname}\nAge: {_age}\n" +
                $"Gender: {_gender}\nProfession: footballer\nSalary: {_salary}\nEndurance: {_endurance}\nWeight(kg): {p.Weight}\nHeight(cm): {p.Height}\n" +
                $"Number of scored goals: {_scoredGoals}\nNumber of conceded goals: {_concededGoals}\nid: {_id}\n");
        }
    }
}
