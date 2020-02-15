using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns.MediatorDesignPattern
{
    public interface Mediator
    {
           public void SendMessage(String msg, User user);

            void AddUser(User user);
        

       
    }
}
