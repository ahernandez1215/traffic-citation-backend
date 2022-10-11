﻿// <auto-generated />
using System;
using CitationWebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CitationWebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221005232100_changeType")]
    partial class changeType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc.1.22426.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CitationWebAPI.Models.Citation", b =>
                {
                    b.Property<int>("citation_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("citation_id"));

                    b.Property<string>("code_section")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("date")
                        .HasColumnType("date");

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("driver_id")
                        .HasColumnType("int");

                    b.Property<string>("officer_badge")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("officer_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("owner_fault")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("sign_date")
                        .HasColumnType("date");

                    b.Property<TimeSpan?>("time")
                        .HasColumnType("time");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.Property<string>("vin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vin_state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("violation_loc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("citation_id");

                    b.ToTable("Citations");
                });

            modelBuilder.Entity("CitationWebAPI.Models.Driver", b =>
                {
                    b.Property<int>("driver_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("driver_id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("date_birth")
                        .HasColumnType("date");

                    b.Property<string>("driver_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eyes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hair")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("height")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("license_class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("license_no")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("race")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("weight")
                        .HasColumnType("int");

                    b.Property<int>("zip")
                        .HasColumnType("int");

                    b.HasKey("driver_id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("CitationWebAPI.Models.User", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("user_id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("officer_badge")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("officer_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("user_id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
