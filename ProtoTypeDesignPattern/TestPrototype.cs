using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.ProtoTypeDesignPattern
{
  public class TestPrototype
    {
        public static void Test()
        {
            static void ShallowCopy()
            {
                Employee empRamki = new Employee()
                {
                    Id = Guid.NewGuid(),
                    Name = "Ramki",
                    DeptId = 150,     
                };
                Console.WriteLine(empRamki.ToString());
                Employee empRagu = (Employee)empRamki.Clone();

            }
        }
    }
}
