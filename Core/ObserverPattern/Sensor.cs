namespace Core.ObserverPattern
{
    public class Sensor : Subject
    {
        private readonly int value;
        public Sensor(int value)
        {
            this.value = value;
        }

        public void Check()
        {
            Notify();
        }

        public double GetValue()
        {
            return value;
        }
    }
}
