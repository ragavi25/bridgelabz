// --------------------------------------------------------------------------------------------------------------------
// <copyright file=TestPrototype.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// ---------------------------------------------------------------------------------------------------------

using System;

namespace DesiginPattern.ProtoTypeDesignPattern
{
    public class TestPrototype
    {
        /// <summary>
        /// Purpose:Test the clone to Employee. 
        /// </summary>

        public static void Test()
        {
            ShallowCopy();
            ShallowCopyRef();
            DeepCopy();
        }
        /// <summary>
        /// Purpose:ShallowCopy used to copy the empioyee to another employee. 
        /// </summary>
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
        /// <summary>
        /// Purpose:ShallowCopyRef used to the adding some values lone to the employee.
        /// </summary>
            static void ShallowCopyRef()
            {
                Employee emp = new Employee(1, "Ramki", 150)
                {
                    Name = "Ragu",
                    DeptId = 150
                };

                Address empRamki1 = new Address("TN", "THENI");
                Console.Write(empRamki1.ToString());
                Address empRagu = (Address)empRamki1.Clone();
               // empRagu.State = "kerla";
                //empRagu.City= "abc";
                Console.Write(emp.ToString());
                Console.Write(empRagu.ToString());
                Console.WriteLine("Modified Ramki Details:");
                empRamki1.State = "Ka";
                empRamki1.City = "CVB";
                emp.DeptId = 161;
               Console.WriteLine(emp.ToString());
                Console.WriteLine(empRamki1.ToString());
                Console.WriteLine(empRagu.ToString());
            }
        /// <summary>
        /// Puepose:Get the original values.
        /// </summary>
            static void DeepCopy()
            {
                Employee emp = new Employee(1, "Ramki", 150)
                {
                    Name = "Ragu",
                    DeptId = 150
                };

                Address empRamki1 = new Address("TN", "THENI");
                Console.Write(empRamki1.ToString());
                Address empRagu = (Address)empRamki1.DeepCopy();
                empRagu.State = "kerla";
                empRagu.City= "abc";
                Console.Write(emp.ToString());
                Console.Write(empRagu.ToString());
                Console.WriteLine("Modified Ramki Details:");
                empRamki1.State = "Ka";
                empRamki1.City = "CVB";
                emp.DeptId = 161;
                //  Console.WriteLine(emp.ToString());
                Console.WriteLine(empRamki1.ToString());
                Console.WriteLine(empRagu.ToString());
            }
        
    }
}
 