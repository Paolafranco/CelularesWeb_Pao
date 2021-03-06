﻿// <auto-generated />
using System;
using DeberPrograPao1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DeberPrograPao1.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20200716121754_FabricaOtros")]
    partial class FabricaOtros
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DeberPrograPao1.Models.Bodega", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BodegueroId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BodegueroId");

                    b.ToTable("Bodegas");
                });

            modelBuilder.Entity("DeberPrograPao1.Models.Celular", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BodegaId")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BodegaId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Celulares");
                });

            modelBuilder.Entity("DeberPrograPao1.Models.Computadora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BodegaId")
                        .HasColumnType("int");

                    b.Property<int?>("FotoId")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BodegaId");

                    b.HasIndex("FotoId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Computadoras");
                });

            modelBuilder.Entity("DeberPrograPao1.Models.ComputadoraFoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Fotografia")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("ComputadoraFoto");
                });

            modelBuilder.Entity("DeberPrograPao1.Models.Impresora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BodegaId")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BodegaId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Impresoras");
                });

            modelBuilder.Entity("DeberPrograPao1.Models.Mouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BodegaId")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BodegaId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Mouses");
                });

            modelBuilder.Entity("DeberPrograPao1.Models.Persona", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("DeberPrograPao1.Models.Tablet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BodegaId")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BodegaId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Tablets");
                });

            modelBuilder.Entity("DeberPrograPao1.Models.Bodega", b =>
                {
                    b.HasOne("DeberPrograPao1.Models.Persona", "Bodeguero")
                        .WithMany()
                        .HasForeignKey("BodegueroId");
                });

            modelBuilder.Entity("DeberPrograPao1.Models.Celular", b =>
                {
                    b.HasOne("DeberPrograPao1.Models.Bodega", null)
                        .WithMany("Celulares")
                        .HasForeignKey("BodegaId");

                    b.HasOne("DeberPrograPao1.Models.Persona", null)
                        .WithMany("Celulares")
                        .HasForeignKey("PersonaId");
                });

            modelBuilder.Entity("DeberPrograPao1.Models.Computadora", b =>
                {
                    b.HasOne("DeberPrograPao1.Models.Bodega", null)
                        .WithMany("Computadora")
                        .HasForeignKey("BodegaId");

                    b.HasOne("DeberPrograPao1.Models.ComputadoraFoto", "Foto")
                        .WithMany()
                        .HasForeignKey("FotoId");

                    b.HasOne("DeberPrograPao1.Models.Persona", null)
                        .WithMany("Computadora")
                        .HasForeignKey("PersonaId");
                });

            modelBuilder.Entity("DeberPrograPao1.Models.Impresora", b =>
                {
                    b.HasOne("DeberPrograPao1.Models.Bodega", null)
                        .WithMany("Impresoras")
                        .HasForeignKey("BodegaId");

                    b.HasOne("DeberPrograPao1.Models.Persona", null)
                        .WithMany("Impresoras")
                        .HasForeignKey("PersonaId");
                });

            modelBuilder.Entity("DeberPrograPao1.Models.Mouse", b =>
                {
                    b.HasOne("DeberPrograPao1.Models.Bodega", null)
                        .WithMany("Mouses")
                        .HasForeignKey("BodegaId");

                    b.HasOne("DeberPrograPao1.Models.Persona", null)
                        .WithMany("Mouses")
                        .HasForeignKey("PersonaId");
                });

            modelBuilder.Entity("DeberPrograPao1.Models.Tablet", b =>
                {
                    b.HasOne("DeberPrograPao1.Models.Bodega", null)
                        .WithMany("Tablets")
                        .HasForeignKey("BodegaId");

                    b.HasOne("DeberPrograPao1.Models.Persona", null)
                        .WithMany("Tablets")
                        .HasForeignKey("PersonaId");
                });
#pragma warning restore 612, 618
        }
    }
}
