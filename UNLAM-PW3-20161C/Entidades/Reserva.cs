using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Reserva
    {
        public int idReserva { get; set; }
        public string usuarioReserva { get; set; }
        public string eventoReserva { get; set; }
        public string recetaReserva { get; set; }
        public int comensalesReserva { get; set; }
    }
}
