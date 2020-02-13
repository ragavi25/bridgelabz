using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.ProtoTypeDesignPattern
{
  public class Icloneable :Employee
    {
        /// <summary>
        /// Icloneable interface one clone method return the object use the MemberwiseClone.
        /// </summary>
        /// <returns>Current object </returns>
        public object Clone()
        {
            ////return the clone current object of Employee.
            return this.MemberwiseClone();
        }
    }
}
