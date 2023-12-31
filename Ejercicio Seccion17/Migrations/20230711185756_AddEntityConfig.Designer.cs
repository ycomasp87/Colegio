﻿// <auto-generated />
using System;
using Ejercicio_Seccion17.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ejercicio_Seccion17.Migrations
{
    [DbContext(typeof(ContextDB))]
    [Migration("20230711185756_AddEntityConfig")]
    partial class AddEntityConfig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ejercicio_Seccion17.Models.Alumno", b =>
                {
                    b.Property<int>("AlumnoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClaseId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.HasKey("AlumnoId");

                    b.HasIndex("ClaseId");

                    b.ToTable("Alumno");
                });

            modelBuilder.Entity("Ejercicio_Seccion17.Models.Clase", b =>
                {
                    b.Property<int>("ClaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ColegioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("ProfesorId")
                        .HasColumnType("int");

                    b.HasKey("ClaseId");

                    b.HasIndex("ColegioId");

                    b.HasIndex("ProfesorId");

                    b.ToTable("Clase");
                });

            modelBuilder.Entity("Ejercicio_Seccion17.Models.Colegio", b =>
                {
                    b.Property<int>("ColegioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("ColegioId");

                    b.ToTable("Colegio");
                });

            modelBuilder.Entity("Ejercicio_Seccion17.Models.Profesor", b =>
                {
                    b.Property<int>("ProfesorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("ProfesorId");

                    b.ToTable("Profesor");
                });

            modelBuilder.Entity("Ejercicio_Seccion17.Models.Alumno", b =>
                {
                    b.HasOne("Ejercicio_Seccion17.Models.Clase", "Clase")
                        .WithMany("Alumnos")
                        .HasForeignKey("ClaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ejercicio_Seccion17.Models.Clase", b =>
                {
                    b.HasOne("Ejercicio_Seccion17.Models.Colegio", null)
                        .WithMany("Clases")
                        .HasForeignKey("ColegioId");

                    b.HasOne("Ejercicio_Seccion17.Models.Profesor", "Profesor")
                        .WithMany("Clases")
                        .HasForeignKey("ProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
