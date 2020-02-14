using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.StructuralDesignPatterns.ProxyDesignPattern
{
    class CommandExcuteProxy : CommandExecutor
    {
        private bool isAdmin;
        private CommandExecutor executor;

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
