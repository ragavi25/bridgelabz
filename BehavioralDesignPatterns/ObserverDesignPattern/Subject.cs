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
    /// 
    /// </summary>
     public interface ISubject
    {
        public void Register(IObservers obj);
        public void UnRegister(IObservers obj);
        public void NotifyObserver();
        public Object GetUptate(IObservers obj);
    }
}
