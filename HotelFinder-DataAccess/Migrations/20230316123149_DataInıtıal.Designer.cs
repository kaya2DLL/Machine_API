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
    [Migration("20230316123149_DataInıtıal")]
    partial class DataInıtıal
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

                    b.Property<string>("IpAddress")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("MachineNumber")
                        .HasColumnType("int");

                    b.Property<string>("PLCType")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Port")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("ProductName")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("ServiceCheck")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ServiceCheckControl")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Connections");
                });

            modelBuilder.Entity("Mac.Entities.Machines", b =>
                {
                    b.Property<int>("ConnectionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConnectionID"));

                    b.Property<string>("CurrentProductionaddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Module")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductionAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductionValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConnectionID");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("Mac.Entities.PLCQualityCriterionDatas", b =>
                {
                    b.Property<int>("OID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OID"));

                    b.Property<float>("DataDifferenceValue")
                        .HasColumnType("real");

                    b.Property<int>("DataExplainID")
                        .HasColumnType("int");

                    b.Property<float>("DataValue")
                        .HasColumnType("real");

                    b.Property<int>("MachineID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Times")
                        .HasColumnType("datetime2");

                    b.HasKey("OID");

                    b.ToTable("Datas");
                });
#pragma warning restore 612, 618
        }
    }
}
