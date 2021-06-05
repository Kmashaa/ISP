using System;

namespace lab8
{
    class Human
    {
        protected string _name;
        protected string _surname;
        protected string _age;
        protected string _gender;
        protected string _profession;
        protected string _salary;
        protected uint _id;
        static uint _amount;

        static public string CheckData(string str, int a, int b)
        {
            int count = 0;
            while (count != str.Length)
            {
                count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= a && str[i] <= b)
                    {
                        count++;
                    }
                }
                if (count != str.Length)
                {
                    Console.WriteLine($"{str} - invalid data. Try again");
                    str = Console.ReadLine();
                }
            }
            return str;
        }

         public Human(string name, string surname, string age, string gender, string profession, string salary)
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
            _amount++;
            _id = _amount;
         }

        public Human()
        {
            _name = "";
            _surname = "";
            _age = "";
            _gender = "";
            _profession = "";
            _salary = "";
            _amount++;
            _id = _amount;
        }

        public virtual void Information()
        {
            Console.WriteLine($"\nName: {_name}\nSurname: {_surname}\nAge: {_age}\n" +
                $"Gender: {_gender}\nProfession: {_profession}\nSalary: {_salary}\nid: {_id}\n");
        }

        public void EnterData()
        {
            string inf;

            Console.WriteLine("Please, enter a name");
            inf = Console.ReadLine();
            _name = CheckData(inf, 97, 122);

            Console.WriteLine("Please, enter a surname");
            inf = Console.ReadLine();
            _surname = CheckData(inf, 97, 122);

            Console.WriteLine("Please, enter an age");
            inf = Console.ReadLine();
            _age = CheckData(inf, 48, 57);

            Console.WriteLine("Please, enter a gender(woman or man)");
            inf = Console.ReadLine();
            while (inf != "man" && inf != "woman")
            {
                Console.WriteLine($"{inf} - invalid gender. Try again");
                inf = Console.ReadLine();
            }
            _gender = CheckData(inf, 97, 122);

            Console.WriteLine("Please, enter a profession");
            inf = Console.ReadLine();
            _profession = CheckData(inf, 97, 122);

            Console.WriteLine("Please, enter a salary");
            inf = Console.ReadLine();
            _salary = CheckData(inf, 48, 57);
        }

        public void ChangeInformation(string name)
        {
            _name = CheckData(name, 97, 122);
        }

        public void ChangeInformation(int age)
        {
            string newage = age.ToString();
            _age = CheckData(newage, 48, 57);
        }

        public int CountTime(int sum)
        {
            int time;
            int salary = Convert.ToInt32(_salary);
            if (sum % salary != 0)
            {
                time = (sum / salary) + 1;
                return time;
            }
            else
            {
                time = sum / salary;
                return time;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = CheckData(value, 97, 122);
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = CheckData(value, 97, 122);
            }
        }

        public string Age
        {
            get
            {
                return _age;
            }
            set { }
        }

        public string Gender
        {
            get
            {
                return _gender;
            }
            set { }
        }

        public string Profession
        {
            get
            {
                return _profession;
            }
            set
            {
                _profession = CheckData(value, 97, 122);
            }
        }

        public string this[string field]
        {
            get
            {
                switch (field)
                {
                    case "name": return _name;
                    case "surname": return _surname;
                    case "age": return Convert.ToString(_age);
                    case "gender": return _gender;
                    case "profession": return _profession;
                    case "salary": return _salary;
                    default: return "There is no such field";
                }
            }
        }
    }
}
