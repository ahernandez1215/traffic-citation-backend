﻿// <auto-generated />
using System;
using CitationWebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CitationWebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("CitationWebAPI.Models.Citation", b =>
                {
                    b.Property<int>("citation_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("citation_id"));

                    b.Property<string>("code_section")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("date")
                        .HasColumnType("date");

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("driver_id")
                        .HasColumnType("integer");

                    b.Property<string>("officer_badge")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("officer_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("owner_fault")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("sign_date")
                        .HasColumnType("date");

                    b.Property<TimeSpan?>("time")
                        .HasColumnType("time");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("user_id")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("vin")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("vin_state")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("violation_loc")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("citation_id");

                    b.ToTable("Citations");
                });

            modelBuilder.Entity("CitationWebAPI.Models.Driver", b =>
                {
                    b.Property<int>("driver_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("driver_id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("date_birth")
                        .HasColumnType("date");

                    b.Property<string>("driver_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("eyes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("hair")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("height")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("license_class")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("license_no")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("race")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<char>("sex")
                        .HasColumnType("character(1)");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("weight")
                        .HasColumnType("integer");

                    b.Property<int>("zip")
                        .HasColumnType("integer");

                    b.HasKey("driver_id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("CitationWebAPI.Models.Violation", b =>
                {
                    b.Property<int>("violation_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("violation_id"));

                    b.Property<int>("citation_id")
                        .HasColumnType("integer");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("degree")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("group")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("violation_id");

                    b.ToTable("Violations");
                });
#pragma warning restore 612, 618
        }
    }
}
