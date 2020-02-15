using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns.MediatorDesignPattern
{
    /// <summary>
    /// 
    /// </summary>
    public class MediatorImpl : Mediator
    {
        /// <summary>
        /// 
        /// </summary>
        private List<User> users;
        /// <summary>
        /// 
        /// </summary>
        public MediatorImpl ()
        {
            this.users = new List<User>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(User user)
        {
            this.users.Add(user);
        }
        /// <summary>
        /// 
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
