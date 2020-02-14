using DesiginPattern.StructuralDesignPatterns;
using System;

namespace DesiginPattern.StructuralDesignPatterns
{
    internal class CommandExecutorImpl : CommandExecutor
    {
        public object Runtime { get; private set; }

        public void RunCommand(string cmd)
        {
            //some heavy implementation
            Runtime = cmd;
            Console.WriteLine(" " + cmd + "Command Excute");
        }

        private object getRuntime()
        {
            return Runtime;
        }
    }
}