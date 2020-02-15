﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MediatorClient.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// ----------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns.MediatorDesignPattern
{
    /// <summary>
    /// 
    /// </summary>
    public interface Mediator
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="msg"></param>
    /// <param name="user"></param>
           public void SendMessage(String msg, User user);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
            void AddUser(User user);
        

       
    }
}
