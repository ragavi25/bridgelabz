// --------------------------------------------------------------------------------------------------------------------
// <copyright file=TestProxy.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// ----------------------------------------------------------------------------------------
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.StructuralDesignPatterns
{
    /// <summary>
    ///  Purpose:here is our interface and its implementation class.
    /// </summary>
    public interface CommandExecutor
    {
        public void RunCommand(string cmd);


    }
}
