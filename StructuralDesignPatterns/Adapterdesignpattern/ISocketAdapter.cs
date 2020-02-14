using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.StructuralDesignPatterns.Adapterdesignpattern
{
    public interface ISocketAdapter
    {/// <summary>
     /// purpose:create an adapter interface with these methods
     /// </summary>
     /// <returns></returns>
        public Volt Get120Volt();
        public Volt Get12Volt();
        public Volt Get3Volt(); 
    }
}
