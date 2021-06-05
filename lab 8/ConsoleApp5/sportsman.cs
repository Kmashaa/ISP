



namespace lab8
{
    abstract class Sportsman : Human
    {
        protected string _endurance { get; set; }
        protected int _weight { get; set; }
        protected string _height { get; set; }
        public abstract void LoseWeight();
        public abstract void LoseWeight(int num);
        public abstract void ParticipInComp();
        public Sportsman() { }
        public Sportsman(string name, string surname, string age, string gender, string profession, string salary) :
            base(name, surname, age, gender, profession, salary)
        { }
       

    }
}
