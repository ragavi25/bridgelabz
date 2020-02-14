// --------------------------------------------------------------------------------------------------------------------
// <copyright file=TestProxy.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// ----------------------------------------------------------------------------------------
using System;

namespace DesiginPattern.StructuralDesignPatterns
{
    public class ProxyPatternText
    { 
        public static void Text()
        {
        CommandExecutor executor = new CommandExcuteProxy("Ragavi", "wrong_pwd");
        try 
            {
			executor.RunCommand("ls -ltr");
			executor.RunCommand(" rm -rf abc.pdf");
		    } 
      catch (Exception e)
        {
			Console.WriteLine("Exception Message::"+e.Message);
        }
        }
    }
}
