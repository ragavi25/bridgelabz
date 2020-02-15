﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns.ObserverDesignPattern
{
    public class ObserverPatternTest
    {
        public static void Test()
        {
            MyTopic topic = new MyTopic();
            //IObservers OBJ = null;
            IObservers obj1 = new MyTopicSubscriber("Person1:");
            IObservers obj2 = new MyTopicSubscriber("Person2:");
            IObservers obj3 = new MyTopicSubscriber("Person3:");
            topic.Register(obj1);
            topic.Register(obj2);
            topic.Register(obj3);
            obj1.setSubject(topic);
            obj2.setSubject(topic);
            obj3.setSubject(topic);
            obj1.Uptate();
            topic.PostMsg("New Message");

        }
    }
   
}
