using System.Collections.Generic;

namespace Core.ObserverPattern
{
    public class Subject
    {
        private readonly List<IObserver> observerList;
        public Subject()
        {
            observerList = new List<IObserver>();
        }

        public void Register(IObserver observer)
        {
            observerList.Add(observer);
        }

        protected void Notify()
        {
            foreach (IObserver observer in observerList)
            {
                observer.Update((Sensor)this);
            }
        }
    }
}
