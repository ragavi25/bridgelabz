using Amazon.DeviceFarm.Model;
using Couchbase.Configuration.Server.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.Factory_Pattern
{
    public class PC : Computer
    {
        private string ram;
        private string cpu;
        private string hdd;

        public PC(string ram, string cpu, string hdd)
        {
            this.ram = ram;
            this.cpu = cpu;
            this.hdd = hdd;
        }
        public override string Ram()
        {
            return this.ram;
        }
        public override string Cpu()
        {
            return this.cpu;
        }

        public override string Hdd()
        {
            return this.hdd;
        }

       
    }
}
