// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ObserverPatternTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// -------------------------------------------------------------------------------------------------------
using DesiginPattern.BehavioralDesignPatterns.ObserverDesignPattern;

namespace DesiginPattern.BehavioralDesignPatterns
{
    /// <summary>
    /// 
    /// </summary>
    public interface IObservers
    {
        public void Uptate();
        public void setSubject(ISubject subject);
    }
}