using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.StructuralDesignPatterns.Adapterdesignpattern
{
    public interface ISocketAdapter
    {
        public Volt Get120Volt();
        public Volt Get12Volt();
        public Volt Get3Volt(); 
    }
}
