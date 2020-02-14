using System;
using System.Collections.Generic;
using System.Text;

// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AdapterPattenTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// ----------------------------------------------------------------------------------------
namespace DesiginPattern.StructuralDesignPatterns.Adapterdesignpattern
{
    public interface ISocketAdapter
    {/// <summary>
     /// purpose:create an adapter interface with these methods
     /// </summary>
     /// <returns></returns>
        public Volt Get120Volt();
        public Volt Get12Volt();
        public Volt Get3Volt(); 
    }
}
