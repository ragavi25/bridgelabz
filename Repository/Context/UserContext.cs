﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using Fundoo.Model;
using Microsoft.EntityFrameworkCore;
using Model.Model.NodesModel;
using Model.Model.LabelModel;

namespace Repository.Context
{
    public class UserContext : DbContext
   {
        /// <summary>
        /// Purpose:UseContext using the Database connection.
        /// </summary>
        /// <param name="options"></param>
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
       /// <summary>
       /// Purpose:create the Registers table.
       /// </summary>
        public DbSet<RegisterModel> registers { get; set; }
        public DbSet<Nodes> Nodes { get; set; }
        public DbSet<Label> labels { get; set; }
      

    }
}
