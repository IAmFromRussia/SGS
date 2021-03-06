﻿// <auto-generated />
using System;
using Infrastructure.DataAcess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DbConsole.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200719111141_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Entities.JsonDataClasses.Valute", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("CharCode")
                        .HasColumnName("charCode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Nominal")
                        .HasColumnName("nominal")
                        .HasColumnType("int");

                    b.Property<string>("NumCode")
                        .HasColumnName("numCode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Previous")
                        .HasColumnName("previous")
                        .HasColumnType("double");

                    b.Property<double>("Value")
                        .HasColumnName("value")
                        .HasColumnType("double");

                    b.HasKey("ID");

                    b.ToTable("Valutes");
                });
#pragma warning restore 612, 618
        }
    }
}
