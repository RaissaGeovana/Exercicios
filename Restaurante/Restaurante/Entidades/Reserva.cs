using System;

namespace Restaurante.Entidades
{
    public class Reserva
    {
        public int Identificador { get; set; }
        public DateTime InicioReserva { get; set; }
        public DateTime FimReserva { get; set; }
        public Entidades.Mesas Mesa { get; set; }
        public Entidades.Cliente Cliente { get; set; }

    }
}
