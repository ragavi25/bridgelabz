using DesiginPattern.BehavioralDesignPatterns.ObserverDesignPattern;
using Sigil;
using System;
using System.Collections.Generic;

namespace DesiginPattern.BehavioralDesignPatterns
{
    public class MyTopic : ISubject
    {
        private List<IObservers> observer;
        private string Message;
        private bool Changed;
      //  private  Object MUTEX = new Object();
       // private object synchronized;

        public MyTopic()
        {
            this.observer = new List<IObservers>();
        }
        public object GetUptate(IObservers obj)
        {
            return this.Message;
        }

        public void NotifyObserver()
        {
            List<IObservers> local = null;
            if (!Changed)
                return;
            local = new List<IObservers>(this.observer);
            this.Changed = false;
            foreach(IObservers obj in local)
            {
                obj.Uptate();
            }
        }

        public void Register(IObservers obj)
        {
            if (obj == null) throw new Exception("Null Observers");
            observer.Add(obj);

        }

        public void UnRegister(IObservers obj)
        {
            observer.Remove(obj);
        }
        public void PostMsg(string msg)
        {
            Console.WriteLine("Message:" + msg);
            this.Message = msg;
            this.Changed = true;
            this.NotifyObserver();

        }
    }

    
}
