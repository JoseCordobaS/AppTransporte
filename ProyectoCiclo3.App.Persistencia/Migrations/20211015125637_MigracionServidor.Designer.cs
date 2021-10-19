﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoCiclo3.App.Persistencia;

namespace ProyectoCiclo3.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211015125637_MigracionServidor")]
    partial class MigracionServidor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ProyectoCiclo3.App.Dominio.Buses", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("kilometraje")
                        .HasColumnType("int");

                    b.Property<string>("marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("modelo")
                        .HasColumnType("int");

                    b.Property<int>("numero_asientos")
                        .HasColumnType("int");

                    b.Property<string>("placa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Buses");
                });

            modelBuilder.Entity("ProyectoCiclo3.App.Dominio.Estaciones", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("coord_x")
                        .HasColumnType("real");

                    b.Property<float>("coord_y")
                        .HasColumnType("real");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Estaciones");
                });

            modelBuilder.Entity("ProyectoCiclo3.App.Dominio.Rutas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("destino")
                        .HasColumnType("int");

                    b.Property<int>("origen")
                        .HasColumnType("int");

                    b.Property<int>("tiempo_estimado")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Rutas");
                });
#pragma warning restore 612, 618
        }
    }
}
