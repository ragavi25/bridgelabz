using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns.ObserverDesignPattern
{
    class ObserverPatternTest
    {
        public void Test()
        {
            MyTopic topic = new MyTopic();
            IObservers obj1 = new MyTopicSubscriber("Person1");
            IObservers obj2 = new MyTopicSubscriber("Person2");
            IObservers obj3 = new MyTopicSubscriber("Person3");
            topic.Register(obj1);
            topic.Register(obj2);
            topic.Register(obj3);
            obj1.setSubject(topic);
            obj2.setSubject(topic);
            obj3.setSubject(topic);

        }
    }
}
