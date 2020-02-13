using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.ProtoTypeDesignPattern
{
    public class TestPrototype
    {
        

        public static void Test()
        {
            ShallowCopy();
            ShallowCopyRef();
            static void ShallowCopy()
            {
                Employee empRamki = new Employee(1,"Ramki",150);
                
                Console.WriteLine(empRamki.ToString());
                Employee empRagu = (Employee)empRamki.Clone();
                empRagu.Name = "Ragu";
                Console.WriteLine(empRagu.ToString());
                Console.WriteLine("Changed Ramki DeptementId to 160");
                empRamki.DeptId = 160;
                Console.WriteLine(empRamki.ToString());
               
            }
            static void ShallowCopyRef()
            {
                Address empRamki = new Address(  "THENI", "TN");
                Console.WriteLine(empRamki.ToString());
                Address empRagu = (Address)empRamki.Clone();
                Employee emp = new Employee(1, "Ramki", 150);
                emp.Name = "Ragu";
                emp.DeptId = 150;
                empRagu.State = "kerla";
                empRagu.City= "abc";
                Console.WriteLine(emp.ToString());
                Console.WriteLine(empRagu);
                Console.WriteLine("Modified Ramki Details:");
                empRamki.State = "Ka";
                empRamki.City = "CVB";
                emp.DeptId = 161;
               Console.WriteLine(emp.ToString());
                Console.WriteLine(empRamki.ToString());
                //Console.WriteLine(empRagu.ToString());
            }
        }
    }
}
 