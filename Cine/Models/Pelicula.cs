using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine.Models
{
    public class Pelicula
    {
        public int peliculaID { get; set; }

        public String nombre { get; set; }

        public String descripcion { get; set; }

        public String trailer { get; set; }

        public String imagen { get; set; }

        public String genero { get; set; }

        public int duracionS{ get; set; }

        public List<Funcion> funciones { get; set; }

        public String obtenerDuracionTotal()
        {
            String retorno = "";

            return retorno;
        }
    }

   
}
