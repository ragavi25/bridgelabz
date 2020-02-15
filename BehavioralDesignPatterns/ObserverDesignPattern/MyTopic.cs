// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ObserverPatternTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// -------------------------------------------------------------------------------------------------------
using DesiginPattern.BehavioralDesignPatterns.ObserverDesignPattern;
using Sigil;
using System;
using System.Collections.Generic;

namespace DesiginPattern.BehavioralDesignPatterns
{
    /// <summary>
    /// 
    /// </summary>
    public class MyTopic : ISubject
    {
        private List<IObservers> observer;
        private string Message;
        private bool Changed;
      //  private  Object MUTEX = new Object();
       // private object synchronized;
       /// <summary>
       /// 
       /// </summary>
        public MyTopic()
        {
            this.observer = new List<IObservers>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public object GetUptate(IObservers obj)
        {
            return this.Message;
        }
        /// <summary>
        /// 
        /// </summary>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        public void Register(IObservers obj)
        {
            if (obj == null) throw new Exception("Null Observers");
            observer.Add(obj);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        public void UnRegister(IObservers obj)
        {
            observer.Remove(obj);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public void PostMsg(string msg)
        {
            Console.WriteLine("Message:" + msg);
            this.Message = msg;
            this.Changed = true;
            this.NotifyObserver();

        }
    }

    
}
