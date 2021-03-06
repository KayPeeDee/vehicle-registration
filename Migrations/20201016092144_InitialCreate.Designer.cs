﻿// <auto-generated />
using System;
using CrudmvcApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrudmvcApp.Migrations
{
    [DbContext(typeof(VehicleContext))]
    [Migration("20201016092144_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("CrudmvcApp.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfRegistration")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("MonthlyInsuranceAmount")
                        .HasColumnType("TEXT");

                    b.Property<string>("OwnerNationalIdNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("VehicleRegNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
