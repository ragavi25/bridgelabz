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
    /// purpose: Test program to consume our topic implementation.
    /// </summary>
    public class ObserverPatternTest
    {
        /// <summary>
        /// TEST metod used to test the topic.
        /// </summary>
        public static void Test()
        {
            ////create a Sbject
            MyTopic topic = new MyTopic();
            ////IObservers OBJ = null;\
            ///Create a Observer.
            IObservers obj1 = new MyTopicSubscriber("Person1:");
            IObservers obj2 = new MyTopicSubscriber("Person2:");
            IObservers obj3 = new MyTopicSubscriber("Person3:");
            ////Register observer to the  Subject.
            topic.Register(obj1);
            topic.Register(obj2);
            topic.Register(obj3);
            ////Attach Observer to the Subject.
            obj1.setSubject(topic);
            obj2.setSubject(topic);
            obj3.setSubject(topic);
            ////check if any update is available
            obj1.Uptate();
            ////Now sent to Subject.
            topic.PostMsg("New Message");

        }
    }
   
}
