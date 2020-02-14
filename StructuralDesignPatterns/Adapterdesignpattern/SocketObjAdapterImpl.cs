using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.StructuralDesignPatterns.Adapterdesignpattern
{
    /// <summary>
    /// Purpose:uses of Composition and adapter contains the source object.
    /// </summary>
    public class SocketObjAdapterImpl : ISocketAdapter
    {
        /// <summary>
        ///  the adapter implementations are almost same and they implement the SocketAdapter interface.
        /// </summary>
        private Socket sock = new Socket();
        public Volt Get120Volt()
        {
            return sock.GetVolt();
        }

        public Volt Get12Volt()
        {
           Volt v = sock.GetVolt();
            return ConvertSock(v, 10);

        }

        private Volt ConvertSock(Volt v1, int v2)
        {
            return new Volt(v1.getVolts() / v2);
        }

        public Volt Get3Volt()
        {
            Volt v = sock.GetVolt();
            return ConvertSock(v, 40);

        }
    }
}
