﻿namespace DesiginPattern.Factory_Pattern
{
    /// <summary>
    /// 
    /// </summary>
    public class Server : Computer
    {/// <summary>
     /// 
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
