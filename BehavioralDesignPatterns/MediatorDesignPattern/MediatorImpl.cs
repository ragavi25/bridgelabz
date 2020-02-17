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
    /// Purprose:create concrete mediator class.
    /// </summary>
    public class MediatorImpl : IMediator
    {
        /// <summary>
        ///  it will have a list of users in the group and provide logic for the communication between the users.
        /// </summary>
        private List<User> users;
       
        public MediatorImpl ()
        {
            this.users = new List<User>();
        }
        /// <summary>
        /// pupose of Add the users.
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(User user)
        {
            this.users.Add(user);
        }
        /// <summary>
        /// pupose of used to SendMessage to Users.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="user"></param>
        
        public void SendMessage(string msg, User user)
        {
            foreach(User user1 in this.users )
            {
                if(user1 !=user)
                {
                    user1.Recevie(msg);
                }

            }
        }
    }
}
