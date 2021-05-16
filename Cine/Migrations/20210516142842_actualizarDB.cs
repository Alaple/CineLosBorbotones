using Microsoft.EntityFrameworkCore.Migrations;

namespace Cine.Migrations
{
    public partial class actualizarDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcion_Pelicula_peliculaID",
                table: "Funcion");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcion_Sala_salaID",
                table: "Funcion");

            migrationBuilder.DropForeignKey(
                name: "FK_Pelicula_Cines_cineID",
                table: "Pelicula");

            migrationBuilder.DropForeignKey(
                name: "FK_Sala_Cines_cineID",
                table: "Sala");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Cines_cineID",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Usuario_usuarioID",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Cines_cineID",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sala",
                table: "Sala");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pelicula",
                table: "Pelicula");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcion",
                table: "Funcion");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Ticket",
                newName: "Tickets");

            migrationBuilder.RenameTable(
                name: "Sala",
                newName: "Salas");

            migrationBuilder.RenameTable(
                name: "Pelicula",
                newName: "Peliculas");

            migrationBuilder.RenameTable(
                name: "Funcion",
                newName: "Funciones");

            migrationBuilder.RenameIndex(
                name: "IX_Usuario_cineID",
                table: "Usuarios",
                newName: "IX_Usuarios_cineID");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_usuarioID",
                table: "Tickets",
                newName: "IX_Tickets_usuarioID");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_cineID",
                table: "Tickets",
                newName: "IX_Tickets_cineID");

            migrationBuilder.RenameIndex(
                name: "IX_Sala_cineID",
                table: "Salas",
                newName: "IX_Salas_cineID");

            migrationBuilder.RenameIndex(
                name: "IX_Pelicula_cineID",
                table: "Peliculas",
                newName: "IX_Peliculas_cineID");

            migrationBuilder.RenameIndex(
                name: "IX_Funcion_salaID",
                table: "Funciones",
                newName: "IX_Funciones_salaID");

            migrationBuilder.RenameIndex(
                name: "IX_Funcion_peliculaID",
                table: "Funciones",
                newName: "IX_Funciones_peliculaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "usuarioID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets",
                column: "ticketID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salas",
                table: "Salas",
                column: "salaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Peliculas",
                table: "Peliculas",
                column: "peliculaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funciones",
                table: "Funciones",
                column: "funcionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Funciones_Peliculas_peliculaID",
                table: "Funciones",
                column: "peliculaID",
                principalTable: "Peliculas",
                principalColumn: "peliculaID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funciones_Salas_salaID",
                table: "Funciones",
                column: "salaID",
                principalTable: "Salas",
                principalColumn: "salaID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Peliculas_Cines_cineID",
                table: "Peliculas",
                column: "cineID",
                principalTable: "Cines",
                principalColumn: "cineID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Salas_Cines_cineID",
                table: "Salas",
                column: "cineID",
                principalTable: "Cines",
                principalColumn: "cineID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Cines_cineID",
                table: "Tickets",
                column: "cineID",
                principalTable: "Cines",
                principalColumn: "cineID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Usuarios_usuarioID",
                table: "Tickets",
                column: "usuarioID",
                principalTable: "Usuarios",
                principalColumn: "usuarioID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Cines_cineID",
                table: "Usuarios",
                column: "cineID",
                principalTable: "Cines",
                principalColumn: "cineID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funciones_Peliculas_peliculaID",
                table: "Funciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Funciones_Salas_salaID",
                table: "Funciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Peliculas_Cines_cineID",
                table: "Peliculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Salas_Cines_cineID",
                table: "Salas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Cines_cineID",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Usuarios_usuarioID",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Cines_cineID",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salas",
                table: "Salas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Peliculas",
                table: "Peliculas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funciones",
                table: "Funciones");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "Tickets",
                newName: "Ticket");

            migrationBuilder.RenameTable(
                name: "Salas",
                newName: "Sala");

            migrationBuilder.RenameTable(
                name: "Peliculas",
                newName: "Pelicula");

            migrationBuilder.RenameTable(
                name: "Funciones",
                newName: "Funcion");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_cineID",
                table: "Usuario",
                newName: "IX_Usuario_cineID");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_usuarioID",
                table: "Ticket",
                newName: "IX_Ticket_usuarioID");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_cineID",
                table: "Ticket",
                newName: "IX_Ticket_cineID");

            migrationBuilder.RenameIndex(
                name: "IX_Salas_cineID",
                table: "Sala",
                newName: "IX_Sala_cineID");

            migrationBuilder.RenameIndex(
                name: "IX_Peliculas_cineID",
                table: "Pelicula",
                newName: "IX_Pelicula_cineID");

            migrationBuilder.RenameIndex(
                name: "IX_Funciones_salaID",
                table: "Funcion",
                newName: "IX_Funcion_salaID");

            migrationBuilder.RenameIndex(
                name: "IX_Funciones_peliculaID",
                table: "Funcion",
                newName: "IX_Funcion_peliculaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "usuarioID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket",
                column: "ticketID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sala",
                table: "Sala",
                column: "salaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pelicula",
                table: "Pelicula",
                column: "peliculaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcion",
                table: "Funcion",
                column: "funcionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcion_Pelicula_peliculaID",
                table: "Funcion",
                column: "peliculaID",
                principalTable: "Pelicula",
                principalColumn: "peliculaID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcion_Sala_salaID",
                table: "Funcion",
                column: "salaID",
                principalTable: "Sala",
                principalColumn: "salaID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pelicula_Cines_cineID",
                table: "Pelicula",
                column: "cineID",
                principalTable: "Cines",
                principalColumn: "cineID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sala_Cines_cineID",
                table: "Sala",
                column: "cineID",
                principalTable: "Cines",
                principalColumn: "cineID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Cines_cineID",
                table: "Ticket",
                column: "cineID",
                principalTable: "Cines",
                principalColumn: "cineID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Usuario_usuarioID",
                table: "Ticket",
                column: "usuarioID",
                principalTable: "Usuario",
                principalColumn: "usuarioID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Cines_cineID",
                table: "Usuario",
                column: "cineID",
                principalTable: "Cines",
                principalColumn: "cineID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
