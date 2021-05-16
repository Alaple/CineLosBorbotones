using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine.Models
{
    public class Usuario
    {
        public int usuarioID { get; set; }
        public String mail { get;  set; }
        public String clave { get;  set; }
        public Boolean esAdmin { get;  set; }
        public String nombre { get;  set; }
        public String apellido { get;  set; }
        public String dni { get;  set; }
        public String direccion { get;  set; }
        public String telefono { get;  set; }
        public List<Ticket> tickets { get;  set; }

        public void getHistorial()
        {

        }

    }
}
