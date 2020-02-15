using DesiginPattern.BehavioralDesignPatterns.ObserverDesignPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns
{
    public class MyTopic : Subject
    {
        private List<Observer> observer;
        private string Message;
        private bool Changed;
        private Object MUTEX = new Object();
        public object GetUptate(Observer obj)
        {
            throw new NotImplementedException();
        }

        public void NotifyObserver()
        {
            throw new NotImplementedException();
        }

        public void Register(Observer obj)
        {
            throw new NotImplementedException();
        }

        public void UnRegister(Observer obj)
        {
            throw new NotImplementedException();
        }
    }
}
