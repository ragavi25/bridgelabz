using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.ProtoTypeDesignPattern
{
  public class Icloneable : Employee
    {
        public Icloneable(int id, string name, int deptId) : base(id, name, deptId)
        {
            this.Id = id;
            this.Name = name;
            this.DeptId = deptId;
        }



        /// <summary>
        /// Icloneable interface one clone method return the object use the MemberwiseClone.
        /// </summary>
        /// <returns>Current object </returns>
        public new object Clone()
        {
            ////return the clone current object of Employee.
            return this.MemberwiseClone();
        }
    }
}
