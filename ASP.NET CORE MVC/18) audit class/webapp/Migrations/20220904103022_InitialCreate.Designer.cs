﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapp.Models;

namespace webapp.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20220904103022_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("webapp.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Age")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("updatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
