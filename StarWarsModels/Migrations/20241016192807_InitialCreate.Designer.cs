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
    [Migration("20241016192807_InitialCreate")]
    partial class InitialCreate
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

                    b.Property<string>("MGLT")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cargo_capacity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("consumables")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cost_in_credits")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("crew")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("edited")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string[]>("films")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<double>("hyperdrive_rating")
                        .HasColumnType("double precision");

                    b.Property<double>("length")
                        .HasColumnType("double precision");

                    b.Property<string>("manufacturer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("max_atmosphering_speed")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("passengers")
                        .HasColumnType("integer");

                    b.Property<string[]>("pilots")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("starship_class")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Starship");
                });
#pragma warning restore 612, 618
        }
    }
}