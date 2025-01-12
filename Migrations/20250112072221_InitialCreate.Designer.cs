﻿// <auto-generated />
using DDFinace_Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DDFinaceBackend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250112072221_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("DDFinace_Backend.Models.Policy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("InsuranceType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PolicyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PolicyNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PremiumAmount")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Policies");
                });
#pragma warning restore 612, 618
        }
    }
}
