using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cine.Migrations
{
    public partial class CineDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pelicula",
                columns: table => new
                {
                    peliculaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    trailer = table.Column<string>(nullable: true),
                    imagen = table.Column<string>(nullable: true),
                    genero = table.Column<string>(nullable: true),
                    duracionS = table.Column<int>(nullable: false),
                    cineID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pelicula", x => x.peliculaID);
                    table.ForeignKey(
                        name: "FK_Pelicula_Cines_cineID",
                        column: x => x.cineID,
                        principalTable: "Cines",
                        principalColumn: "cineID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sala",
                columns: table => new
                {
                    salaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    numero = table.Column<int>(nullable: false),
                    cineID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sala", x => x.salaID);
                    table.ForeignKey(
                        name: "FK_Sala_Cines_cineID",
                        column: x => x.cineID,
                        principalTable: "Cines",
                        principalColumn: "cineID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    usuarioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    mail = table.Column<string>(nullable: true),
                    clave = table.Column<string>(nullable: true),
                    esAdmin = table.Column<bool>(nullable: false),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    dni = table.Column<string>(nullable: true),
                    direccion = table.Column<string>(nullable: true),
                    telefono = table.Column<string>(nullable: true),
                    cineID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.usuarioID);
                    table.ForeignKey(
                        name: "FK_Usuario_Cines_cineID",
                        column: x => x.cineID,
                        principalTable: "Cines",
                        principalColumn: "cineID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Funcion",
                columns: table => new
                {
                    funcionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dia = table.Column<string>(nullable: true),
                    hora = table.Column<string>(nullable: true),
                    cantButacasLibres = table.Column<int>(nullable: false),
                    peliculaID = table.Column<int>(nullable: true),
                    salaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcion", x => x.funcionID);
                    table.ForeignKey(
                        name: "FK_Funcion_Pelicula_peliculaID",
                        column: x => x.peliculaID,
                        principalTable: "Pelicula",
                        principalColumn: "peliculaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcion_Sala_salaID",
                        column: x => x.salaID,
                        principalTable: "Sala",
                        principalColumn: "salaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    ticketID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nroTicket = table.Column<int>(nullable: false),
                    numero = table.Column<int>(nullable: false),
                    cantEntradas = table.Column<int>(nullable: false),
                    precioEntrada = table.Column<double>(nullable: false),
                    esTarjeta = table.Column<bool>(nullable: false),
                    cineID = table.Column<int>(nullable: true),
                    usuarioID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.ticketID);
                    table.ForeignKey(
                        name: "FK_Ticket_Cines_cineID",
                        column: x => x.cineID,
                        principalTable: "Cines",
                        principalColumn: "cineID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Usuario_usuarioID",
                        column: x => x.usuarioID,
                        principalTable: "Usuario",
                        principalColumn: "usuarioID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcion_peliculaID",
                table: "Funcion",
                column: "peliculaID");

            migrationBuilder.CreateIndex(
                name: "IX_Funcion_salaID",
                table: "Funcion",
                column: "salaID");

            migrationBuilder.CreateIndex(
                name: "IX_Pelicula_cineID",
                table: "Pelicula",
                column: "cineID");

            migrationBuilder.CreateIndex(
                name: "IX_Sala_cineID",
                table: "Sala",
                column: "cineID");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_cineID",
                table: "Ticket",
                column: "cineID");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_usuarioID",
                table: "Ticket",
                column: "usuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_cineID",
                table: "Usuario",
                column: "cineID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcion");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Pelicula");

            migrationBuilder.DropTable(
                name: "Sala");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
