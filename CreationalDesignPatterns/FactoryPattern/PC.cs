// --------------------------------------------------------------------------------------------------------------------
// <copyright file=TestFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// ---------------------------------------------------------------------------------------

namespace DesiginPattern.Factory_Pattern
{/// <summary>
/// Creating sub-classes of Pc.
/// </summary>
    public class PC : Computer
    {
        /// <summary>
        /// The sub-classes pc  are extending Computer super class.
        /// </summary>
        private readonly string ram;
        private readonly string cpu;
        private readonly string hdd;

        public PC(string ram, string cpu, string hdd)
        {
            ////This purpose of geting the curent value.
            this.ram = ram;
            this.cpu = cpu;
            this.hdd = hdd;
        }
        public override string Ram()
        {
            ////Override the Ram instance
            return this.ram;
        }
        public override string Cpu()
        {
            ////Override the Cpu instance
            return this.cpu;
        }

        public override string Hdd()
        {
            ////override the Hdd instance
            return this.hdd;
        }

       
    }
}
