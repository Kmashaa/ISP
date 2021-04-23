using System;
using Sport;

namespace Run
{
    class Runner:Sportsman
    {
        public struct Parameters
        {
            public int Weight;
            public string Height;
        }
        Parameters p;
        protected int _maxDistance { get; set; }
        protected string _presenceOfRecords { get; set; }
        public Runner(string name, string surname, string age, string gender, string profession,
                      string salary, string endurance, int weight, string height, int maxDistance, string presenceOfRecords = "no"):
            base( name, surname, age, gender, profession,  salary)
        {
           /*_name = CheckData(name, 97, 122);
            _surname = CheckData(surname, 97, 122);
            _age = CheckData(age, 48, 57);
            while (gender != "man" && gender != "woman")
            {
                Console.WriteLine($"{_gender} - invalid gender. Try again");
                gender = Console.ReadLine();
            }
            _gender = gender;
            _profession = CheckData(profession, 97, 122);
            _salary = CheckData(salary, 48, 57);*/
            _endurance = CheckData(endurance, 47, 57);
            p.Weight = weight;
            p.Height = CheckData(height, 48, 57);
            _maxDistance = maxDistance;
            if (presenceOfRecords == "no"|| presenceOfRecords == "yes")
            {
                _presenceOfRecords = presenceOfRecords;
            }
            else 
            {
                while (!(presenceOfRecords == "no" || presenceOfRecords == "yes"))
                {
                   Console.WriteLine("Invalid status of precence of records. Please try again");
                   presenceOfRecords= Console.ReadLine();
                }
            }
            _presenceOfRecords= CheckData(presenceOfRecords, 97, 122);
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
        public void SetRecord()
        {
            _presenceOfRecords = "yes";
        }
        public void NewMaxDistance(int dist)
        {
            if (dist > _maxDistance)
            {
                _maxDistance = dist;
            }
        }
        public override void Information()
        {
            Console.WriteLine($"\nName: {_name}\nSurname: {_surname}\nAge: {_age}\n" +
                $"Gender: {_gender}\nProfession: runner\nSalary: {_salary}\nEndurance: {_endurance}\nWeight(kg): {p.Weight}\nHeight(cm): {p.Height}\n" +
                $"Max distance(km): {_maxDistance}\nPresence of Records: {_presenceOfRecords}\nid: {_id}\n");
        }
    }
}
