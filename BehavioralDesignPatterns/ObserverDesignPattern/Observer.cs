// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ObserverPatternTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// -------------------------------------------------------------------------------------------------------
using DesiginPattern.BehavioralDesignPatterns.ObserverDesignPattern;

namespace DesiginPattern.BehavioralDesignPatterns
{
   
    public interface IObservers
    {
        /// <summary>
        /// method to update the observer, used by subject
        /// </summary>
        public void Uptate();
        /// <summary>
        /// Attach whith subject to observer.
        /// </summary>
        /// <param name="subject"></param>
        public void setSubject(ISubject subject);
    }
}