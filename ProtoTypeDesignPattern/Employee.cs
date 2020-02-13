using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.ProtoTypeDesignPattern
{
    public class Employee
    {
        private int v1;
        private string v2;
        private int v3;

        public Employee(int id, string name, int deptId,string state,string city)
        {
            Id = id;
            Name = name;
            DeptId = deptId;
           
        }

        public Employee(int id, string name, int deptid)
        {
            this.Id = id;
            this.Name = name;
            this.DeptId=deptid;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
       
       
        public override string ToString()
        {
            ////To print the employee Details.
            return string.Format ("Name:"+this.Name +"  "+ "DeptId:"+this.DeptId.ToString());
        }

        public new Employee Clone()
       {
            
            return new Employee(this.Id,this.Name,this.DeptId);
        }
    }
}
