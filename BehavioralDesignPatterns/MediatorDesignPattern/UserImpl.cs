// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MediatorClient.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// -------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns.MediatorDesignPattern
{
    /// <summary>
    /// 
    /// </summary>
    public class UserImpl : User
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly string Name;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="m"></param>
        /// <param name="Name"></param>
        public UserImpl(Mediator m, string Name)
        {
            M = m;
            this.Name = Name;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>

        public override void Recevie(string msg)
        {
            Console.WriteLine(this.Name + "Recivied Message: " +msg);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public override void Send(string msg)
        {
            Console.WriteLine(this.Name + "Sending Message:" + msg);
            M.SendMessage(msg, this);
        }
    }
}
