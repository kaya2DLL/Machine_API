﻿// <auto-generated />
using System;
using HotelFinder_DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelFinder_DataAccess.Migrations
{
    [DbContext(typeof(MacDbContext))]
    [Migration("20230308110402_DataInitial")]
    partial class DataInitial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelFinder.Entities.Connection", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("DeviceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InputNumber")
                        .HasColumnType("int");

                    b.Property<int>("IpAddress")
                        .HasColumnType("int");

                    b.Property<int>("MachineNumber")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ServiceCheck")
                        .HasColumnType("datetime2");

                    b.Property<string>("TerminalType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThreadSleepTime")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Connections");
                });
#pragma warning restore 612, 618
        }
    }
}