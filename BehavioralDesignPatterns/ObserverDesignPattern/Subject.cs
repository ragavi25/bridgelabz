using System;
using System.Collections.Generic;
using System.Text;
// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ObserverPatternTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// -------------------------------------------------------------------------------------------------------
namespace DesiginPattern.BehavioralDesignPatterns.ObserverDesignPattern
{
    /// <summary>
    /// Creating Subject Interface used to communication to Observers.
    /// </summary>
     public interface ISubject
    {
        /// <summary>
        /// Method to Register Observere.
        /// </summary>
        /// <param name="obj"></param>
        public void Register(IObservers obj);
        /// <summary>
        /// Method to Unregister Observer.
        /// </summary>
        /// <param name="obj"></param>
        public void UnRegister(IObservers obj);
        /// <summary>
        /// method to notify observers of change
        /// </summary>
        public void NotifyObserver();
        /// <summary>
        /// Method to getUpdate from Observer.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public Object GetUptate(IObservers obj);
    }
}
