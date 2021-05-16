using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine.Models
{
    public class Cine
    {
        public int cineID { get; set; }
        public String nombre { get; set; }

        public List<Usuario> usuarios { get; private set; }
        public List<Ticket> tickets { get; private set; }

        public List<Sala> salas { get; private set; }
        public List<Pelicula> peliculas { get; private set; }


        public void verFunciones()
        {

        }
        public void generarTicket()
        {

        }
        public void agregarSala()
        {

        }
        public void mostratTicket()
        {

        }
        public void getFuncion()
        {

        }
        public void nombrePelicula()
        {

        }

        public Pelicula seleccionarPelicula()
        {
            Pelicula retorno = null;
            return retorno;
        }

        public void mostrarPelicula()
        {

        }

        public void mostrarPeliculaProxi()
        {

        }

        public Pelicula buscarPelicula(String peli)
        {
            Pelicula retorno = null;
            return retorno;

        }

    }
}
