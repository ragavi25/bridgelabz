using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns.MediatorDesignPattern
{
    public class MediatorImpl : Mediator
    {
        private List<User> users;
        public MediatorImpl ()
        {
            this.users = new List<User>();
        }
        public void AddUser(User user)
        {
            this.users.Add(user);
        }

        public void SendMessage(string msg, User user)
        {
            
        }
    }
}
