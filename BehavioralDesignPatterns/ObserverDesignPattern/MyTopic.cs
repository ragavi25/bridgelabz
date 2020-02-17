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
    /// purpose:proceed with the concrete implementation of our topic.
    /// </summary>
    public class MyTopic : ISubject
    {
        private List<IObservers> observer;
        private string Message;
        private bool Changed;
        /// <summary>
        /// Purpose:Used to list of Observers in topics.
        /// </summary>
        public MyTopic()
        {
            this.observer = new List<IObservers>();
        }
        /// <summary>
        /// purpose:Update the Observer Messages.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public object GetUptate(IObservers obj)
        {
            return this.Message;
        }
        /// <summary>
        /// purpose:used to make sure any observer registered after message is received is  notified.
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
        /// Purpose:Used to Register of Observer.
        /// </summary>
        /// <param name="obj"></param>
        public void Register(IObservers obj)
        {
            if (obj == null) throw new Exception("Null Observers");
            observer.Add(obj);

        }
        /// <summary>
        /// Purpose:Unregister observer to remove the observer. 
        /// </summary>
        /// <param name="obj"></param>
        public void UnRegister(IObservers obj)
        {
            observer.Remove(obj);
        }
        /// <summary>
        /// purpose:post Message to the Observer.
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
