using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.ProtoTypeDesignPattern
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
        public Address AddressDetails { get; set; }
        public override string ToString()
        {
            ////To print the employee Details.
            return string.Format ("Name: {0} "+"DeptId : {1}",this.Name,this.DeptId.ToString());
        }

        internal Employee Clone()
        {
            return new Employee();
        }
    }
}
