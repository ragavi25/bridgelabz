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
    /// Purpose: test this our  application with a Mediator program
    /// </summary>
    public class MediatorClient
    {
        /// <summary>
        /// purpose:create mediator and add users to the group and one of the user will send a message.
        /// </summary>
        public static void Test()
        {
            
           IMediator mediator = new MediatorImpl();
            ////Passing  Dependencies.
            User user = new UserImpl(mediator, "Ragavi:");
            User user1 = new UserImpl(mediator, "Ramya:");
            User user2 = new UserImpl(mediator, "Ramki:");
            User user3 = new UserImpl(mediator, "Ragu:");
            //// Passing Method Dependencies.
            mediator.AddUser(user);
            mediator.AddUser(user1);
            mediator.AddUser(user2);
            mediator.AddUser(user3);
            user.Send("Hi All,Welcome");

        }
    }
}
