using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine.Models
{
    public class Pelicula
    {
        public int peliculaID { get; set; }

        public String nombre { get; private set; }

        public String descripcion { get; private set; }

        public String trailer { get; private set; }

        public String imagen { get; private set; }

        public String genero { get; private set; }

        public int duracionS{ get; private set; }

        public List<Funcion> funciones { get; private set; }

        public String obtenerDuracionTotal()
        {
            String retorno = "";

            return retorno;
        }
    }

   
}
