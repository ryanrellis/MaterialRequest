﻿// <auto-generated />
using System;
using MaterialRequest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MaterialRequest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210508163834_InitiateDbAndAddRequestTable")]
    partial class InitiateDbAndAddRequestTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MaterialRequest.Models.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PartNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Priority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeNeeded")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}
