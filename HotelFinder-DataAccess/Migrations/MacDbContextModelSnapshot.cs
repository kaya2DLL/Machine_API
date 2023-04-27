﻿// <auto-generated />
using System;
using HotelFinder_DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelFinder_DataAccess.Migrations
{
    [DbContext(typeof(MacDbContext))]
    partial class MacDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("DataExplainID")
                        .HasColumnType("int");

                    b.Property<double>("DataValue")
                        .HasColumnType("float");

                    b.Property<int>("MachineID")
                        .HasColumnType("int");

                    b.HasKey("OID");

                    b.HasIndex("MachineID");

                    b.ToTable("PLCQualityCriterionDatas");
                });

            modelBuilder.Entity("Mac.Entities.PLCQualityCriterionDatas", b =>
                {
                    b.HasOne("Mac.Entities.Machines", "Machines")
                        .WithMany("PLCQualityCriterionDatas")
                        .HasForeignKey("MachineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Machines");
                });

            modelBuilder.Entity("Mac.Entities.Machines", b =>
                {
                    b.Navigation("PLCQualityCriterionDatas");
                });
#pragma warning restore 612, 618
        }
    }
}
