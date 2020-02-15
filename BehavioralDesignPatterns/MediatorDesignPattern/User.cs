using System;

namespace DesiginPattern.BehavioralDesignPatterns.MediatorDesignPattern
{
    public abstract class User
    {
        protected Mediator M;
            protected string Name;
        public abstract void Send(string msg);
        public abstract void Recevie(string msg);
    }
}