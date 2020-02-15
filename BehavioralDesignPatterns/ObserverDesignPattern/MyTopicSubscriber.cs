using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns.ObserverDesignPattern
{
    public class MyTopicSubscriber : IObservers
    {
        private string Name;
        private ISubject topic;
        public MyTopicSubscriber(string UserName)
        {
            this.Name = UserName;
        }
        public void setSubject(ISubject subject)
        {
            this.topic = subject;
        }

        public void Uptate()
        {
            string msg = (string)topic.GetUptate(this);
            if (msg == null)
            {
                Console.WriteLine("NO new Message");
            }
            else
            {
                Console.WriteLine(Name + "New Message" + msg);
            }
        }
    }
}
