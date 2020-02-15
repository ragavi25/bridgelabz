using DesiginPattern.BehavioralDesignPatterns.ObserverDesignPattern;
using Sigil;
using System;
using System.Collections.Generic;

namespace DesiginPattern.BehavioralDesignPatterns
{
    public class MyTopic : Subject
    {
        private List<Observer> observer;
        private string Message;
        private bool Changed;
        private  Object MUTEX = new Object();
       // private object synchronized;

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
            List<Observer> local = null;
            if (!Changed)
                return;
            local = new List<Observer>(this.observer);
            this.Changed = false;
            foreach(Observer obj in local)
            {
                obj.Uptate();
            }
        }

        public void Register(Observer obj)
        {
            if (obj == null) throw new Exception("Null Observers");
            observer.Add(obj);

        }

        public void UnRegister(Observer obj)
        {
            observer.Remove(obj);
        }
    }

    
}
