using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns.ObserverDesignPattern
{
    interface ISubject
    {
        public void Register(IObservers obj);
        public void UnRegister(IObservers obj);
        public void NotifyObserver();
        public Object GetUptate(IObservers obj);
    }
}
