using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.StructuralDesignPatterns.Adapterdesignpattern
{
    public class Socket
    {
        public Volt GetVolt()
        {
            return new Volt(120);
        }
    }
}
