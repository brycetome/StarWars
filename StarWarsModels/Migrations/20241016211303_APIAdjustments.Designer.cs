﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StarWarsModels;

#nullable disable

namespace StarWarsModels.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241016211303_APIAdjustments")]
    partial class APIAdjustments
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("StarWarsModels.Starship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CargoCapacity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Consumables")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CostInCredits")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Crew")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("Edited")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string[]>("Films")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<double>("HyperDriveRating")
                        .HasColumnType("double precision");

                    b.Property<double>("Length")
                        .HasColumnType("double precision");

                    b.Property<string>("MGLT")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MaxAtomspheringSpeed")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Passengers")
                        .HasColumnType("integer");

                    b.Property<string[]>("Pilots")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("StarshipClass")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Starship");
                });
#pragma warning restore 612, 618
        }
    }
}
