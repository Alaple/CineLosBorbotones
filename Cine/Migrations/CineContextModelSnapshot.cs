﻿// <auto-generated />
using System;
using Cine.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cine.Migrations
{
    [DbContext(typeof(CineContext))]
    partial class CineContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cine.Models.Cine", b =>
                {
                    b.Property<int>("cineID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre");

                    b.HasKey("cineID");

                    b.ToTable("Cines");
                });

            modelBuilder.Entity("Cine.Models.Funcion", b =>
                {
                    b.Property<int>("funcionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cantButacasLibres");

                    b.Property<string>("dia");

                    b.Property<string>("hora");

                    b.Property<int?>("peliculaID");

                    b.Property<int?>("salaID");

                    b.HasKey("funcionID");

                    b.HasIndex("peliculaID");

                    b.HasIndex("salaID");

                    b.ToTable("Funciones");
                });

            modelBuilder.Entity("Cine.Models.Pelicula", b =>
                {
                    b.Property<int>("peliculaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("cineID");

                    b.Property<string>("descripcion");

                    b.Property<int>("duracionS");

                    b.Property<string>("genero");

                    b.Property<string>("imagen");

                    b.Property<string>("nombre");

                    b.Property<string>("trailer");

                    b.HasKey("peliculaID");

                    b.HasIndex("cineID");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("Cine.Models.Sala", b =>
                {
                    b.Property<int>("salaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("cineID");

                    b.Property<int>("numero");

                    b.HasKey("salaID");

                    b.HasIndex("cineID");

                    b.ToTable("Salas");
                });

            modelBuilder.Entity("Cine.Models.Ticket", b =>
                {
                    b.Property<int>("ticketID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cantEntradas");

                    b.Property<int?>("cineID");

                    b.Property<bool>("esTarjeta");

                    b.Property<int>("nroTicket");

                    b.Property<int>("numero");

                    b.Property<double>("precioEntrada");

                    b.Property<int?>("usuarioID");

                    b.HasKey("ticketID");

                    b.HasIndex("cineID");

                    b.HasIndex("usuarioID");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Cine.Models.Usuario", b =>
                {
                    b.Property<int>("usuarioID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido");

                    b.Property<int?>("cineID");

                    b.Property<string>("clave");

                    b.Property<string>("direccion");

                    b.Property<string>("dni");

                    b.Property<bool>("esAdmin");

                    b.Property<string>("mail");

                    b.Property<string>("nombre");

                    b.Property<string>("telefono");

                    b.HasKey("usuarioID");

                    b.HasIndex("cineID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Cine.Models.Funcion", b =>
                {
                    b.HasOne("Cine.Models.Pelicula", "pelicula")
                        .WithMany("funciones")
                        .HasForeignKey("peliculaID");

                    b.HasOne("Cine.Models.Sala")
                        .WithMany("funciones")
                        .HasForeignKey("salaID");
                });

            modelBuilder.Entity("Cine.Models.Pelicula", b =>
                {
                    b.HasOne("Cine.Models.Cine")
                        .WithMany("peliculas")
                        .HasForeignKey("cineID");
                });

            modelBuilder.Entity("Cine.Models.Sala", b =>
                {
                    b.HasOne("Cine.Models.Cine")
                        .WithMany("salas")
                        .HasForeignKey("cineID");
                });

            modelBuilder.Entity("Cine.Models.Ticket", b =>
                {
                    b.HasOne("Cine.Models.Cine")
                        .WithMany("tickets")
                        .HasForeignKey("cineID");

                    b.HasOne("Cine.Models.Usuario")
                        .WithMany("tickets")
                        .HasForeignKey("usuarioID");
                });

            modelBuilder.Entity("Cine.Models.Usuario", b =>
                {
                    b.HasOne("Cine.Models.Cine")
                        .WithMany("usuarios")
                        .HasForeignKey("cineID");
                });
#pragma warning restore 612, 618
        }
    }
}
