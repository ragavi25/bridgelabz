using EmployeeManagement.Controller;
using EmployeeManagement.EmployeeViews;
using EmployeeManagement.Model;
using Moq;
using NUnit.Framework;
using System;

namespace NUnitTestcase
{
    public class Tests
    {
        [Test]
        public void Login()
        {
            var emp = new Employees();
            emp.Email = "ragavi15@gmail.com";
            emp.Password = "123";
            var empobj = new EmployeeView();
            Assert.False(empobj.Login(emp.Email,emp.Password));
        }
        [Test]
        public void Register()
        {
            try
            {
                var emp = new Employees();
                emp.FirstName = "Ragavi";
                emp.LastName = "Rajendran";
                emp.Email = "ragavi@gmail.com";
                emp.Password = "123";
                emp.Mobile = "24235456";
                var empobj = new EmployeeView();
                empobj.Add(emp);
            }
            catch (Exception e)
            {
                Assert.AreEqual("sqlException", e.GetType().Name);
            }
        }
        [Test]
        public void Update()
        {
            try
            {
                var emp = new Employees();
                emp.FirstName = "Ragavi";
                emp.LastName = "Rajendran";
               emp.Email = "ragavi@gmail.com";
                emp.Password = "123";
                emp.Mobile = "24235456";
                var empobj = new EmployeeView();
                empobj.Update(emp);
            }
            catch (Exception e)
            {
                Assert.AreEqual("SqlException", e.GetType().FullName);
            }
           
        }
        [Test]
        public void Delete()
        {
            try
            {
                var emp = new Employees();
                emp.ID1 = 1;
                var empobj = new EmployeeView();
                empobj.Delete(emp.ID1);
            }
            catch (Exception e)
            {
                Assert.AreEqual("SqlException", e.GetType().FullName);
            }
        }
        [Test]
        public void get()
        {
            try
            {
                var empl = new Employees();
                empl.ID1 = 1;
                empl.FirstName = "";
                empl.LastName = "";
                empl.Email = "";
                empl.Password = "";
                empl.Mobile = "";
                var obj = new EmployeeView();
                obj.Get();
            }
                catch(Exception g)
            {
                Assert.AreEqual("SqlException", g.GetType().FullName);
            }
            }




    }
}