using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine.Models
{
    public class Ticket
    {
        public int ticketID { get; set; }

        public int nroTicket { get; private set; }

        public int numero { get; private set; }
        public int cantEntradas { get; private set; }
        public double precioEntrada { get; private set; }

        public Boolean esTarjeta { get; private set; }

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
