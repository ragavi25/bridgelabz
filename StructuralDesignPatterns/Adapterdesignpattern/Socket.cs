using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.StructuralDesignPatterns.Adapterdesignpattern
{
    public class Socket
    {
        /// <summary>
        /// Purpose: Socket class using producing constant volts of 120V
        /// </summary>
        /// <returns></returns>
        public Volt GetVolt()
        {
            return new Volt(120);
        }
    }
}
