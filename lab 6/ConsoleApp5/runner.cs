using System;
using Sport;
using ConsoleApp5;

namespace Run
{
    class Runner:Sportsman, ITrain, ICloneable
    {
        public struct Parameters
        {
            public int Weight;
            public string Height;
        }
        Parameters p;

        protected int _maxDistance { get; set; }
        enum PresenceOfRec
        {
            yes, 
            no
        }
        protected string _presenceOfRecords { get; set; }

        public Runner(string name, string surname, string age, string gender, string profession,
                      string salary, string endurance, int weight, string height, int maxDistance, string presenceOfRecords = "no"):
            base( name, surname, age, gender, profession,  salary)
        {
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
            _presenceOfRecords = PresenceOfRec.no.ToString();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
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

        public void SetRecord()
        {
            _presenceOfRecords = PresenceOfRec.yes.ToString();
        }

        public void NewMaxDistance(int dist)
        {
            if (dist > _maxDistance)
            {
                _maxDistance = dist;
            }
        }

        public override void ParticipInComp()
        {
            GainWeight();
            NewMaxDistance(50);
            SetRecord();
        }

        public override void Information()
        {
            Console.WriteLine($"\nName: {_name}\nSurname: {_surname}\nAge: {_age}\n" +
                $"Gender: {_gender}\nProfession: runner\nSalary: {_salary}\nEndurance: {_endurance}\nWeight(kg): {p.Weight}\nHeight(cm): {p.Height}\n" +
                $"Max distance(km): {_maxDistance}\nPresence of Records: {_presenceOfRecords}\nid: {_id}\n");
        }
    }
}
