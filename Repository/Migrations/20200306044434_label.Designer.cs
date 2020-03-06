﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Context;

namespace Repository.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20200306044434_label")]
    partial class label
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fundoo.Model.RegisterModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("registers");
                });

            modelBuilder.Entity("Model.Model.LabelModel.Label", b =>
                {
                    b.Property<int>("LabelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LabelName");

                    b.Property<int>("Noteid");

                    b.HasKey("LabelId");

                    b.ToTable("labels");
                });

            modelBuilder.Entity("Model.Model.NodesModel.Nodes", b =>
                {
                    b.Property<int>("NodeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddImg");

                    b.Property<bool>("Archive");

                    b.Property<string>("ChangeColor");

                    b.Property<DateTime?>("Createdate1");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("Modifieddate");

                    b.Property<bool>("Pin");

                    b.Property<string>("Tittle");

                    b.HasKey("NodeId");

                    b.ToTable("Nodes");
                });
#pragma warning restore 612, 618
        }
    }
}