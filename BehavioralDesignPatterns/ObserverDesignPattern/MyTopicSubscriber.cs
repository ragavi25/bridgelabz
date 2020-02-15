// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ObserverPatternTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// -------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns.ObserverDesignPattern
{
    /// <summary>
    /// 
    /// </summary>
    public class MyTopicSubscriber : IObservers
    {
        private string Name;
        private ISubject topic;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserName"></param>
        public MyTopicSubscriber(string UserName)
        {
            this.Name = UserName;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="subject"></param>
        public void setSubject(ISubject subject)
        {
            this.topic = subject;
        }
        /// <summary>
        /// /
        /// </summary>
        public void Uptate()
        {
            string msg = (string)topic.GetUptate(this);
            if (msg == null)
            {
                Console.WriteLine("NO new Message");
            }
            else
            {
                Console.WriteLine(Name + "New UPDATE Message:" + msg);
            }
        }
    }
}
