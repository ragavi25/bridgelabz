// --------------------------------------------------------------------------------------------------------------------
// <copyright file=TestFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// ----------------------------------------------------------------------------------------
namespace DesiginPattern.Factory_Pattern
{
    /// <summary>
    /// Creating a sub-clases of server. 
    /// </summary>
    public class Server : Computer
    {/// <summary>
     /// The sub-classes Server  are extending Computer super class.
     /// </summary>
        private readonly string cpu;
        private readonly string hdd;
        private readonly string ram;

        public Server(string ram, string cpu, string hdd)
        {
            ////
            this.ram = ram;
            this.cpu = cpu;
            this.hdd = hdd;
        }
        public override string Ram()
        {
            ////
            return this.ram;
        }
        public override string Cpu()
        {
            ////
            return this.cpu;
        }

        public override string Hdd()
        { 
            ////
            return this.hdd;
        }

       
    }
}
