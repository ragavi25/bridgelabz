// --------------------------------------------------------------------------------------------------------------------
// <copyright file=TestProxy.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// ----------------------------------------------------------------------------------------
using DesiginPattern.StructuralDesignPattern;
using System;

namespace DesiginPattern.StructuralDesignPatterns
{
    class CommandExcuteProxy : CommandExecutor
    {
        private bool isAdmin;
        private CommandExecutor executor;
        public CommandExcuteProxy(String user, String pwd)
        {
            if ("Ragavi".Equals(user) && "ragavi@123".Equals(pwd)) isAdmin = true;
            executor = new CommandExecutorImpl();
        }
           public void RunCommand(string cmd)

            {
            if (isAdmin)

            {
                executor.RunCommand(cmd);
            }
            else
            {
                if (cmd.Trim().StartsWith("rm"))
                {
                    throw new Exception("rm command is not allowed for non-admin users.");
                }
                else
                {
                    executor.RunCommand(cmd);
                }
        }   }
    }
}
