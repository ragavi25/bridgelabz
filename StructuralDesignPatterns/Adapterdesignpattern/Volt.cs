using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.StructuralDesignPatterns.Adapterdesignpattern
{
   public class Volt
    {
        private int Volts;
        public  Volt (int v)
        {
            this.Volts = v;
        }
        public int getVolts()
        {
            return Volts;
        }
        public void setVolts (int Volts)
        {
            this.Volts = Volts;
        }
    }
}
