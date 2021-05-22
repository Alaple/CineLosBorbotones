using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine.Models
{
    public class Funcion

      
    {
        public int funcionID { get; set; }

        public String dia { get; set; }

        public String hora { get; set; }

        public int cantButacasLibres { get; set; }

        public Pelicula pelicula { get; set; }

        public void agregarPelicula()
        {

        }
        public void eliminarPelicula()
        {

        }

        public void actualizarPelicula()
        {

        }
        public int cantButacasOcupadas()
        {
            int retorno = 0;
            return retorno;
        }

        public void ocuparButaca()
        {

        }
    }
}
