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
            
            Mediator m = new MediatorImpl();
            User user = new UserImpl(m, "Ragavi:");
            User user1 = new UserImpl(m, "Ramya:");
            User user2 = new UserImpl(m, "Ramki:");
            User user3 = new UserImpl(m, "Ragu:");
            m.AddUser(user);
            m.AddUser(user1);
            m.AddUser(user2);
            m.AddUser(user3);
            user.Send("Hi All,Welcome");

        }
    }
}
