using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.StructuralDesignPatterns.Adapterdesignpattern
{
    public class SocketClassAdapterImpl : Socket, ISocketAdapter
    {
        public Volt Get120Volt()
        {
            return GetVolt();
        }

        public Volt Get12Volt()
        {
            Volt v = GetVolt();
            return convertVolt(v, 10);
        }

        private Volt convertVolt(Volt v, int v1)
        {
            return new Volt(v.getVolts() / v1);
        }

        public Volt Get3Volt()
        {
            Volt v = GetVolt();
            return convertVolt(v, 40);
        }
    }
}
