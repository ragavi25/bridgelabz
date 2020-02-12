using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.Factory_Pattern
{
    public class ComputerFactory
    {
        public static Computer GetComputer(string type,string ram,string cpu,string hdd)
        {
            if ("PC".Equals(type))
            {
                return  new PC(ram, cpu, hdd);

            }
            else if("Server".Equals(type))
            {
                return new Server(ram, cpu, hdd);
            }
            
            return null;
            }

        
    }
}
