// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using Fundoo.Model;
using Manager.Manager;
using Model.Model;
using NUnit.Framework;
using System;

namespace NUnitTestFundoo
{
    public class Tests
    {
        /// <summary>
        /// Purpose:Testing the Register.
        /// </summary>
        [Test]
        public void Register()
        {
            try
            {
                RegisterModel Fundoo = new RegisterModel();
                Fundoo.FirstName = "Hakini";
                Fundoo.LastName = "Vachi";
                Fundoo.Email = "hakini@gmail.com";
                Fundoo.Password = "nithesh";
                Fundoo.Id = "1";
                AccountManagerImpl obj = new AccountManagerImpl();
                _ = obj.Register(Fundoo);

            }
            catch (Exception e)
            {

                Assert.AreEqual("Dbcontext", e.GetType().Name);

            }
        }
        /// <summary>
        /// Purpose:Testing the Login.
        /// </summary>
        [Test]
        public void Login()
        {
            try
            {
                LoginModel Fundoo = new LoginModel();
                Fundoo.Email = "hakini@gmail.com";
                Fundoo.Password = "nithesh";
            }
            catch (Exception e)
            {
                Assert.AreEqual("Dbcontext", e.GetType().FullName);
            }
        }
        /// <summary>
        /// Purpose:Testing the ForgotPassword.
        /// </summary>
        [Test]
        public void ForgotPassword()
        {
            try
            {
                ForgotPasswordModel Fundoo = new ForgotPasswordModel();
                Fundoo.Email = "raghavi15@gmail.com";
            }
            catch (Exception e)
            {
                Assert.AreEqual("Dbcontext", e.GetType().Name);
            }
        }
        /// <summary>
        /// Purpose:Testing the RestPassword.
        /// </summary>
        [Test]
        public void Reset()
        {
            try
            {
                var Fundoo = new ResetPassWord
                {
                    Email = "hakini@gmail.com",
                    Password = "nithesh",
                    Confirmpassword = "nithesh"
                };
                var funobj = new AccountManagerImpl();
                _ = funobj.ResetPassWord(Fundoo);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Dbcontext", e.GetType().Name);
            }
        }
        /// <summary>
        /// Purpose:Testing the EmailLogin.
        /// </summary>
        [Test]
        public void EmailLogin()
        {
            try
            {
                var Fundoo = new LoginModel
                {
                    Email = "hakini@gmail.com",
                    Password = "nithesh"
                };

            }
            catch (Exception e)
            {
                Assert.AreEqual("Dbcontext", e.GetType().Name);
            }
        }
        /// <summary>
        /// Purpose:Testing the FaceBookLogin.
        /// </summary>
        [Test]
        public void FacebookLogin()
        {
            try
            {
                LoginModel Fundoo = new LoginModel();
                Fundoo.Email = "rag@gma";
                Fundoo.Password = "123";   
            }
            catch (Exception e)
            {
                Assert.AreEqual("Dbcontext", e.GetType().Name);
            }
        }
    }
}