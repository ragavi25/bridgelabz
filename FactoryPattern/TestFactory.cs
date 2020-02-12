using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.Factory_Pattern
{
    public class TestFactory
    {
        public void Factory()
        {
            Computer Pc = ComputerFactory.GetComputer("PC", "3GB", "600GB", "3.5GHZ");
        Computer Server = ComputerFactory.GetComputer("Server", "32GB", "2TB", "3.3GHZ");
            Console.WriteLine("Factory PC config:" + Pc);
            Console.WriteLine("Factory Server config:" + Server);
        }

    }
}
