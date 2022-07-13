﻿// <auto-generated />
using System;
using EMS_WebApi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EMS_WebApi.Migrations
{
    [DbContext(typeof(ContextDB))]
    [Migration("20220712091507_Allcompletee")]
    partial class Allcompletee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EMS_WebApi.Model.Admins", b =>
                {
                    b.Property<int>("Admin_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Admin_id"), 1L, 1);

                    b.Property<string>("Admin_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Admin_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Admin_id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("EMS_WebApi.Model.Department", b =>
                {
                    b.Property<int>("Department_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Department_Id"), 1L, 1);

                    b.Property<string>("Department_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Department_Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("EMS_WebApi.Model.Employee", b =>
                {
                    b.Property<int>("Employee_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Employee_Id"), 1L, 1);

                    b.Property<int>("Account_No")
                        .HasColumnType("int");

                    b.Property<string>("Bank_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Create_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DOJ")
                        .HasColumnType("datetime2");

                    b.Property<int>("Department_Id")
                        .HasColumnType("int");

                    b.Property<string>("Email_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IFSC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Is_Admin")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modify_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("PanCard_No")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone_No")
                        .HasColumnType("int");

                    b.Property<int>("Qualification_id")
                        .HasColumnType("int");

                    b.Property<int>("Role_id")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Employee_Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("EMS_WebApi.Model.Employee_Dependent", b =>
                {
                    b.Property<int>("Dependent_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Dependent_Id"), 1L, 1);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Dependent_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Employee_Id")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Relationship")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Dependent_Id");

                    b.ToTable("Employee_Dependent");
                });

            modelBuilder.Entity("EMS_WebApi.Model.Employee_Qualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Employee_Id")
                        .HasColumnType("int");

                    b.Property<int>("Qualification_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employee_Qualification");
                });

            modelBuilder.Entity("EMS_WebApi.Model.Employee_Salary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Basic_Pay")
                        .HasColumnType("int");

                    b.Property<int>("Conveyance_Allowences")
                        .HasColumnType("int");

                    b.Property<int>("Employee_Id")
                        .HasColumnType("int");

                    b.Property<int>("Gross_Salary")
                        .HasColumnType("int");

                    b.Property<int>("HRA")
                        .HasColumnType("int");

                    b.Property<int>("Net_Salary")
                        .HasColumnType("int");

                    b.Property<int>("PF")
                        .HasColumnType("int");

                    b.Property<int>("Special_Allowences")
                        .HasColumnType("int");

                    b.Property<int>("TDS")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employee_Salary");
                });

            modelBuilder.Entity("EMS_WebApi.Model.Employee_Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Employee_Id")
                        .HasColumnType("int");

                    b.Property<int>("Skill_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employee_Skill");
                });

            modelBuilder.Entity("EMS_WebApi.Model.Qualification", b =>
                {
                    b.Property<int>("Qualification_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Qualification_Id"), 1L, 1);

                    b.Property<string>("Qualification_Descr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Qualification_Id");

                    b.ToTable("Qualification");
                });

            modelBuilder.Entity("EMS_WebApi.Model.Role", b =>
                {
                    b.Property<int>("Role_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Role_id"), 1L, 1);

                    b.Property<string>("Role_Descr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Role_id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("EMS_WebApi.Model.Salary", b =>
                {
                    b.Property<int>("Salary_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Salary_Id"), 1L, 1);

                    b.Property<int>("Basic_Pay")
                        .HasColumnType("int");

                    b.Property<int>("Conveyance_Allowences")
                        .HasColumnType("int");

                    b.Property<int>("Employee_Id")
                        .HasColumnType("int");

                    b.Property<int>("Gross_Salary")
                        .HasColumnType("int");

                    b.Property<int>("HRA")
                        .HasColumnType("int");

                    b.Property<string>("Month")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Net_Salary")
                        .HasColumnType("int");

                    b.Property<int>("PF")
                        .HasColumnType("int");

                    b.Property<int>("Special_Allowences")
                        .HasColumnType("int");

                    b.Property<int>("TDS")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Salary_Id");

                    b.ToTable("Salary");
                });

            modelBuilder.Entity("EMS_WebApi.Model.Skill", b =>
                {
                    b.Property<int>("Skill_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Skill_id"), 1L, 1);

                    b.Property<string>("Skill_Descr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skill_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Skill_id");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("EMS_WebApi.Model.Users", b =>
                {
                    b.Property<int>("User_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_id"), 1L, 1);

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
