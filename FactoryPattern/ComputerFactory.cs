// --------------------------------------------------------------------------------------------------------------------
// <copyright file=TestFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// ----------------------------------------------------------------------------------------
namespace DesiginPattern.Factory_Pattern
{/// <summary>
/// We have super classes and sub-classes ready, we can write our ComputerFactory class
/// </summary>
    public class ComputerFactory
    {
        public static Computer GetComputer(string type,string ram,string cpu,string hdd)
        {
            ////Pc equals of the all value printed.
            if ("PC".Equals(type))
            {
                return  new PC(ram, cpu, hdd);

            }
            ////Server equals of the all value printed.
            else if("Server".Equals(type))
            {
                return new Server(ram, cpu, hdd);
            }
            
            return null;
            }

        
    }
}
