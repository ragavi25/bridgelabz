using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.Factory_Pattern
{
    public class Server : Computer
    {
        private string cpu;
        private string hdd;
        private string ram;

        public Server(string ram, string cpu, string hdd)
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
