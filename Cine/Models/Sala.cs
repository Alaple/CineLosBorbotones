using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine.Models
{
    public class Sala
    {
        public int salaID { get; set; }

        public int numero { get; private set; }

        public const int CAPACIDAD_SALA = 0;

        public List<Funcion> funciones { get; private set; }

        public void agregarFuncion()
        {

        }

        public void eleminarFuncion()
        {

        }

        public void actualizarFuncion()
        {

        }
        public void getFuncion()
        {

        }
    }
}
