using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.StructuralDesignPatterns.Adapterdesignpattern
{
   public class Volt
    {
        /// <summary>
        /// purpose:Volt class using to meassure of Volts.
        /// </summary>
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
