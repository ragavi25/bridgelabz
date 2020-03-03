using Fundoo.Model;
using Manager.Manager;
using NUnit.Framework;
using System;

namespace NUnitTestFundoo
{
    public class Tests
    {
        
        [Test]
        public void Register()
        {
            try
            {
                var Fundoo = new RegisterModel();
                Fundoo.FirstName = "Hakini";
                Fundoo.LastName = "Vachi";
                Fundoo.Email = "hakini@gmail.com";
                Fundoo.Password = "nithesh";
                Fundoo.Id = "1";
                var fundobj = new AccountManagerImpl();
                fundobj.Register(Fundoo);
            }
            catch(Exception e)
            {
                
                    Assert.AreEqual("sqlException", e.GetType().Name);
                
            }




           
        }
    }
}