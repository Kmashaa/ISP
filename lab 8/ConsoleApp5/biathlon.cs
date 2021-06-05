using System;


namespace lab8
{
    class Biathlonist : Sportsman, ITrain, IComparable<Biathlonist>
    {
        public struct Parameters
        {
            public int Weight;
            public string Height;
        }
        Parameters p;

        protected string _accuracy { get; set; }
        protected string _normalSpeed { get; set; }

        

        public int CompareTo(Biathlonist compare)
        {
            if (Convert.ToInt32(_salary) > Convert.ToInt32(compare._salary))
                return 1;
            else if (Convert.ToInt32(_salary) < Convert.ToInt32(compare._salary))
                return -1;
            return 0;
        }
        delegate int NewWeight(int x, int y);
        NewWeight operation = (x, y) => x + y;
        public void GainWeight()
        {
            p.Weight = operation(p.Weight, 5);
        }


        public override void LoseWeight()
        {
            Error(p);
            p.Weight--;
        }

        public override void LoseWeight(int lessWeight)
        {
            p.Weight -= lessWeight;
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

        public Biathlonist() { }
        public Biathlonist(string name, string surname, string age, string gender, string profession,
                      string salary, string endurance, int weight, string height,string accuracy , string normalSpeed) :
            base(name, surname, age, gender, profession, salary)
        {
            _endurance = CheckData(endurance, 47, 57);
            p.Weight = weight;
            p.Height = CheckData(height, 48, 57);
            _accuracy = CheckData(accuracy,47,57);
            _normalSpeed = CheckData(normalSpeed,48,57);
        }

        public override void ParticipInComp()
        {
            GainWeight();
            Shoot(1, 1, 0, 1, 1);
            Notify?.Invoke($"\nУчастие в соревнованиях\n");
        }
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        public delegate void Participation(string message);
        public event Participation Notify;
        public override void Information()
        {
            Console.WriteLine($"\nName: {_name}\nSurname: {_surname}\nAge: {_age}\n" +
                $"Gender: {_gender}\nProfession: biathlonist\nSalary: {_salary}\nEndurance: {_endurance}\nWeight(kg): {p.Weight}\nHeight(cm): {p.Height}\n" +
                $"Accuracy: {_accuracy}\nNormal speed(km/h): {_normalSpeed}\nid: {_id}\n");
            
        }
        public static int Error(Parameters p)
        {
            p.Weight/= 0;
            return p.Weight;
        }
    }
}
