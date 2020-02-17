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
    /// purpose:Here is the implementation of Observers that will watch over the subject.
    /// </summary>
    public class MyTopicSubscriber : IObservers
    {
        private string Name;
        private ISubject topic;
        /// <summary>
        /// purpose:Creating MyTopicSubscriber used to Current UserName.
        /// </summary>
        /// <param name="UserName"></param>
        public MyTopicSubscriber(string UserName)
        {
            this.Name = UserName;
        }
        /// <summary>
        /// SetSubject used to set the current topic.
        /// </summary>
        /// <param name="subject"></param>
        public void setSubject(ISubject subject)
        {
            this.topic = subject;
        }
        /// <summary>
        ///  implementation of update() method where it’s calling Subject getUpdate() method to get the message to consume. We could have avoided this call by passing message as argument to update() method.
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
