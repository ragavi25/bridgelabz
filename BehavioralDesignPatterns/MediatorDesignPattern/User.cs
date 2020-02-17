// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MediatorClient.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// -------------------------------------------------------------------------------------------------------
using System;

namespace DesiginPattern.BehavioralDesignPatterns.MediatorDesignPattern
{
    /// <summary>
    /// Purpose:Users can send and receive messages, so we can have User interface or abstract class. I am creating User as abstract class.
    /// </summary>
    public abstract class User
    {
       
        protected IMediator Mediators;
            protected string Name;
        public abstract void Send(string msg);
        public abstract void Recevie(string msg);
    }
}