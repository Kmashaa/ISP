using Person;

namespace Sport
{
    abstract class Sportsman: Human
    {
        protected string _endurance { get; set; }
        protected int _weight { get; set; }
        protected string _height { get; set; }
        public abstract void GainWeight();
        public abstract void GainWeight(int num);
        public abstract void LoseWeight();
        public abstract void LoseWeight(int num);
    }
}
