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
    /// purpose: we can create concrete User classes to be used by client.
    /// </summary>
    public class UserImpl : User
    {
        /// <summary>
        /// this oly purpose of readonly User Name.
        /// </summary>
       
        public UserImpl(IMediator m, string Name)
        {
            Mediators = m;
            this.Name = Name;
        }
        /// <summary>
        /// purpose:Recevie() method used to Receive message to users.
        /// </summary>
        /// <param name="msg"></param>

        public override void Recevie(string msg)
        {
            Console.WriteLine(this.Name + "Recivied Message: " +msg);
        }
        /// <summary>
        /// Purpose:send() method is using mediator to send the message to the users and it has no idea how it will be handled by the mediator.
        /// </summary>
        /// <param name="msg"></param>
        public override void Send(string msg)
        {
            Console.WriteLine(this.Name + "Sending Message:" + msg);
            Mediators.SendMessage(msg, this);
        }
    }
}
