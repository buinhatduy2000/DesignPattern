using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDP
{
    public class Subject
    {
        private List<Observer> _observer = new List<Observer>();

        public void addObserver(Observer observer)
        {
            _observer.Add(observer);
        }

        public void deleteObserver(Observer observer)
        {
            _observer.Remove(observer);
        }

        public void notifyObserver(object arg)
        {
            _observer.ForEach((observer) => observer.Notify(arg));
        }
    }
}
