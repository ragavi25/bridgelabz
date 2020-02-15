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
    /// 
    /// </summary>
    public abstract class User
    {
        /// <summary>
        /// 
        /// </summary>
        protected Mediator M;
            protected string Name;
        public abstract void Send(string msg);
        public abstract void Recevie(string msg);
    }
}