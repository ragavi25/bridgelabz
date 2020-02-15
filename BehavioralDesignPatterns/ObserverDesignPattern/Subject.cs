using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns.ObserverDesignPattern
{
    interface Subject
    {
        public void Register(Observer obj);
        public void UnRegister(Observer obj);
        public void NotifyObserver();
        public Object GetUptate(Observer obj);
    }
}
