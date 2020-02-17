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
    /// Purpose : create Mediator interface that will define the contract for concrete mediators.
    /// </summary>
    public interface IMediator
    {/// <summary>
     /// create a method used to sendMessage to users.
     /// </summary>
     /// <param name="msg"></param>
     /// <param name="user"></param>
        public void SendMessage(String msg, User user);
        /// <summary>
        /// create a method used to AddUsers.
        /// </summary>
        /// <param name="user"></param>
            void AddUser(User user);
        

       
    }
}
