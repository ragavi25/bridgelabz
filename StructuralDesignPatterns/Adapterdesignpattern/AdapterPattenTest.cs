using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.StructuralDesignPatterns.Adapterdesignpattern
{
    public class AdapterPattenTest
    {
        public void Test()
        {

        }
        private static void TestObjectAdapter()
        {
            ISocketAdapter sockad = new SocketObjAdapterImpl();
            {
                Volt v3 = getVolt(sockad, 3);
                Volt V12 = getVolt(sockad, 12);
                Volt v120 = getVolt(sockad, 120);

            }
        }

        private static Volt getVolt(ISocketAdapter sockad, int v)
        {
            switch(v)
            {
                case 3:
                    return sockad.Get3Volt();
                case 12:
                    return sockad.Get12Volt();
                case 120:
                    return sockad.Get120Volt();
                default:
                    return sockad.Get120Volt();
            }
        }
    }
}
