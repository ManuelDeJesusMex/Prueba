﻿// <auto-generated />
using System;
using Empleado23CV.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Empleado23CV.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Empleado23CV.Entities.Empleados", b =>
                {
                    b.Property<int>("PkEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PkEmpleado");

                    b.ToTable("Empleado");
                });
#pragma warning restore 612, 618
        }
    }
}
