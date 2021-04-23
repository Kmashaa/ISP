﻿using System;
using Sport;

namespace Biathlon
{
    class Biathlonist : Sportsman
    {
        public struct Parameters
        {
            public int Weight;
            public string Height;
        }
        Parameters p;
        protected string _accuracy { get; set; }
        protected string _normalSpeed { get; set; }
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
        public void NewAccuracy(string n)
        {
            _accuracy = CheckData(n, 47, 57);
        }
       
       public int[] shooting = new int[5] { 0, 0, 0, 0, 0 };
      
        public void Shoot(int f, int s, int th, int ff, int fff)
        {
            shooting[0] = f;
            shooting[1] = s;
            shooting[2] = th;
            shooting[3] = ff;
            shooting[4] = fff;
            int num = 0;
             for(int i = 0; i < 5; i++)
             {
                  num += shooting[i];

             }
        
            num *= 2;
            
            NewAccuracy(num.ToString());
            _accuracy += "/10";

        }
        public Biathlonist(string name, string surname, string age, string gender, string profession,
                      string salary, string endurance, int weight, string height,string accuracy , string normalSpeed)
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
            _accuracy = CheckData(accuracy,47,57);
            _normalSpeed = CheckData(normalSpeed,48,57);
        }
        public override void Information()
        {
            Console.WriteLine($"\nName: {_name}\nSurname: {_surname}\nAge: {_age}\n" +
                $"Gender: {_gender}\nProfession: runner\nSalary: {_salary}\nEndurance: {_endurance}\nWeight(kg): {_weight}\nHeight(cm): {_height}\n" +
                $"Accuracy: {_accuracy}\nNormal speed(km/h): {_normalSpeed}\n");
        }


    }
}