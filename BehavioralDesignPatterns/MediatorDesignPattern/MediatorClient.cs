using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns.MediatorDesignPattern
{
    public class MediatorClient
    {
        public static void Test()
        {
            Mediator m = new MediatorImpl();
            User user = new UserImpl(m, "Ragavi");
            User user1 = new UserImpl(m, "Ramya");
            User user2 = new UserImpl(m, "Ramki");
            User user3 = new UserImpl(m, "Ragu");
            m.AddUser(user);
            m.AddUser(user1);
            m.AddUser(user2);
            m.AddUser(user3);
            user.Send("Hi All,Welcome");

        }
    }
}
