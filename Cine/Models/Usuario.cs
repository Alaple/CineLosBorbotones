using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine.Models
{
    public class Usuario
    {
        public int usuarioID { get; set; }
        public String mail { get; private set; }
        public String clave { get; private set; }
        public Boolean esAdmin { get; private set; }
        public String nombre { get; private set; }
        public String apellido { get; private set; }
        public String dni { get; private set; }
        public String direccion { get; private set; }
        public String telefono { get; private set; }
        public List<Ticket> tickets { get; private set; }

        public void getHistorial()
        {

        }

    }
}
