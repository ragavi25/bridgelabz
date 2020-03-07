// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using Fundoo.Model;
using Manager.Manager;
using Manager.ManagerImpl;
using Model.Model;
using Model.Model.NodesModel;
using NUnit.Framework;
using Repository.Repository;
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
            RegisterModel Fundoo = new RegisterModel();
            Fundoo.FirstName = "Hakini";
            Fundoo.LastName = "Vachi";
            Fundoo.Email = "hakini@gmail.com";
            Fundoo.Password = "nithesh";
            Fundoo.Id = "1";
            AccountManagerImpl obj = new AccountManagerImpl();
            Assert.IsNotNull(obj.Register(Fundoo));
        }
        /// <summary>
        /// Purpose:Testing the Login.
        /// </summary>
        [Test]
        public void Login()
        {
            LoginModel Fundoo = new LoginModel
            {
                Email = "raghavimr15@gmail.com",
                Password = "1",
            };
            AccountRep obj = new AccountRep();
            Assert.IsNotNull(obj.Login(Fundoo));

        }
        /// <summary>
        /// Purpose:Testing the ForgotPassword.
        /// </summary>
        [Test]
        public void ForgotPassword()
        {

            ForgotPasswordModel Fundoo = new ForgotPasswordModel();
            Fundoo.Email = "raghavimr15@gmail.com";
            var obj = new AccountManagerImpl();
            Assert.IsNotNull(obj.ForgotPassword(Fundoo));

        }
        /// <summary>
        /// Purpose:Testing the RestPassword.
        /// </summary>
        [Test]
        public void Reset()
        {
            var Fundoo = new ResetPassWord
            {
                Email = "raghavimr15@gmail.com",
                Password = "1",
                Confirmpassword = "1",
            };
            var funobj = new AccountManagerImpl();
            Assert.IsNotNull(funobj.ResetPassWord(Fundoo));
        }
        /// <summary>
        /// Purpose:Testing the EmailLogin.
        /// </summary>
        [Test]
        public void EmailLogin()
        {

            LoginModel Fundoo = new LoginModel
            {
                Email = "raghavimr15@gmail.com",
                Password = "1",
            };
            AccountManagerImpl funobj = new AccountManagerImpl();
            Assert.IsNotNull(funobj.EmailLogin(Fundoo));
        }
        /// <summary>
        /// Purpose:Testing the FaceBookLogin.
        /// </summary>
        [Test]
        public void FacebookLogin()
        {
            LoginModel Fundoo = new LoginModel
            {
                Email = "raghavimr15@gmail.com",
                Password = "1",
            };
            AccountManagerImpl funobj = new AccountManagerImpl();
            Assert.IsNotNull(funobj.FaceBookLogin(Fundoo));
        }
        /// <summary>
        /// Purpose:Testing the addnode.
        /// </summary>
        [Test]
        public void add()
        {
            Nodes notes = new Nodes()
            {
                NodeId = 1,
                Tittle = ".net",
                Description ="core",
                Archive = true,
                Pin = true,
                ChangeColor="pink",
                AddImg="cf.jpg",
            };
            NodeManagerImpl obj = new NodeManagerImpl();
            Assert.IsNotNull(obj.AddNote(notes));
        }
        /// <summary>
        /// Purpose:Testing the update.
        /// </summary>
        [Test]
        public void update()
        {
            Nodes notes = new Nodes()
            {
                NodeId = 1,
                Tittle = ".net",
                Description = "core",
                ChangeColor = "pink",
                AddImg = "cf.jpg",
            };
            NodeManagerImpl obj = new NodeManagerImpl();
            Assert.IsNotNull(obj.Update(1,".net","core","pink","cf.jpg"));
        }
        /// <summary>
        /// Purpose:Testing the delete.
        /// </summary>
        [Test]
        public void delete()
        {
            Nodes notes = new Nodes()
            {
                NodeId = 1,
            };
            NodeManagerImpl nodeManagerImpl = new NodeManagerImpl();
            Assert.IsNotNull(nodeManagerImpl.Delete(1));
        }
        /// <summary>
        /// Purpose:testing the get.
        /// </summary>
        [Test]
        public void get()
        {
            Nodes notes = new Nodes()
            {
                NodeId = 1,
                Tittle = ".net",
                Description = "core",
                Archive = true,
                Pin = true,
                ChangeColor = "pink",
                AddImg = "cf.jpg",
            };
            NodeManagerImpl obj = new NodeManagerImpl();
            Assert.IsNotNull(obj.GetNotes());    
        }
    }
}