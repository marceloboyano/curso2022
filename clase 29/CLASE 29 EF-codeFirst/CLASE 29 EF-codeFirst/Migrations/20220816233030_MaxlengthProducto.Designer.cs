﻿// <auto-generated />
using System;
using CLASE_29_EF_codeFirst.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CLASE_29_EF_codeFirst.Migrations
{
    [DbContext(typeof(CodeFirstDbContext))]
    [Migration("20220816233030_MaxlengthProducto")]
    partial class MaxlengthProducto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CLASE_29_EF_codeFirst.Modelo.Deposito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SucursalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SucursalId");

                    b.ToTable("Depositos");
                });

            modelBuilder.Entity("CLASE_29_EF_codeFirst.Modelo.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("CLASE_29_EF_codeFirst.Modelo.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<int?>("DepositoId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("FechaElaboracion")
                        .HasColumnType("datetime2");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepositoId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("CLASE_29_EF_codeFirst.Modelo.Sucursal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cuit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sucursales");
                });

            modelBuilder.Entity("CLASE_29_EF_codeFirst.Modelo.Deposito", b =>
                {
                    b.HasOne("CLASE_29_EF_codeFirst.Modelo.Sucursal", null)
                        .WithMany("Depositos")
                        .HasForeignKey("SucursalId");
                });

            modelBuilder.Entity("CLASE_29_EF_codeFirst.Modelo.Producto", b =>
                {
                    b.HasOne("CLASE_29_EF_codeFirst.Modelo.Deposito", null)
                        .WithMany("Productos")
                        .HasForeignKey("DepositoId");

                    b.HasOne("CLASE_29_EF_codeFirst.Modelo.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("CLASE_29_EF_codeFirst.Modelo.Deposito", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("CLASE_29_EF_codeFirst.Modelo.Sucursal", b =>
                {
                    b.Navigation("Depositos");
                });
#pragma warning restore 612, 618
        }
    }
}
