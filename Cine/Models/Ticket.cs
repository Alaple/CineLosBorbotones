using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine.Models
{
    public class Ticket
    {
        public int ticketID { get; set; }

        public int nroTicket { get; set; }

        public int numero { get; set; }
        public int cantEntradas { get; set; }
        public double precioEntrada { get; set; }

        public Boolean esTarjeta { get; set; }

        public double calcularValorEntrada(int cantEntradas, double precioEntrada)
        {
            double retorno = 0;
            return retorno;
        }
        public int genNroTicket()
        {
            int retorno = 0;

            return retorno;
        }
    }
}
