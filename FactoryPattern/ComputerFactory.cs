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
        /// <summary>
        /// Based on the input parameter, different subclass is created and returned. getComputer is the factory method.
        /// </summary>
        /// <param name="type">Get the various type</param>
        /// <param name="ram">Get the value of ram</param>
        /// <param name="cpu">Get the value of cpu</param>
        /// <param name="hdd">Get the valuse of hdd</param>
        /// <returns>All the value returned </returns>
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
