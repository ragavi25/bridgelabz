using DesiginPattern.BehavioralDesignPatterns.ObserverDesignPattern;
using System;
using System.Collections.Generic;

namespace DesiginPattern.BehavioralDesignPatterns
{
    public class MyTopic : Subject
    {
        private List<Observer> observer;
        private string Message;
        private bool Changed;
        private Object MUTEX = new Object();
        public MyTopic()
        {
            this.observer = new List<Observer>();
        }
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
