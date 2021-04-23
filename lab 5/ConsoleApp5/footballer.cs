using System;
using Sport;

namespace Football
{
    class Footballer : Sportsman
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
                      string salary,string endurance, int weight, string height, int scoredGoals, int concededGoals)
        {
           
            _name = CheckData(name, 97, 122);
            _surname = CheckData(surname, 97, 122);
            _age = CheckData(age, 48, 57);
            while (gender != "man" && gender != "woman")
            {
                Console.WriteLine($"{_gender} - invalid gender. Try again");
                gender = Console.ReadLine();
            }
            _gender = gender;
            _profession = CheckData(profession, 97, 122);
            _salary = CheckData(salary, 48, 57);
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

        public override void GainWeight()
        {
            _weight++;
        }
        public override void GainWeight(int moreWeight)
        {
            _weight += moreWeight;
        }
        public override void LoseWeight()
        {
            _weight--;
        }
        public override void LoseWeight(int lessWeight)
        {
            _weight -= lessWeight;
        }
        public override void Information()
        {
            Console.WriteLine($"\nName: {_name}\nSurname: {_surname}\nAge: {_age}\n" +
                $"Gender: {_gender}\nProfession: footballer\nSalary: {_salary}\nEndurance: {_endurance}\nWeight(kg): {p.Weight}\nHeight(cm): {p.Height}\n" +
                $"Number of scored goals: {_scoredGoals}\nNumber of conceded goals: {_concededGoals}\nid: {_id}\n");
        }
    }
}
