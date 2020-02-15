using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns.MediatorDesignPattern
{
    public class UserImpl : User
    {
        private string Name;

        public UserImpl(Mediator m, string Name)
        {
            M = m;
            this.Name = Name;
        }

        public override void Recevie(string msg)
        {
            Console.WriteLine(this.Name + "Recivied Message: " +msg);
        }

        public override void Send(string msg)
        {
            Console.WriteLine(this.Name + "Sending Message:" + msg);
            M.SendMessage(msg, this);
        }
    }
}
