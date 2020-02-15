using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns.MediatorDesignPattern
{
    public class UserImpl : User
    {

        public override void Recevie(string msg)
        {
            Console.WriteLine(this.Name + "Recivied Message: " +msg);
        }

        public override void Send(string msg)
        {
            
        }
    }
}
