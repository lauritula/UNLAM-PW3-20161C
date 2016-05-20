using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Repositorio
{
    public class ComensalRepositorio
    {
        public static List<Reserva> ListaReserva = new List<Reserva>();

        public void CrearReserva(Reserva nuevaReserva)
        {
            ListaReserva.Add(nuevaReserva);
        }

        public List<Reserva> obtenerReservas()
        {
            return ListaReserva;
        }

        public List<Reserva> reservaPorUsuario(string autor)
        {
            List<Reserva> reservaPorUser = new List<Reserva>();

            foreach (Reserva re in ListaReserva)
            {
                if (re.usuarioReserva == autor)
                    reservaPorUser.Add(re);
            }
            return reservaPorUser;
        }

        public void cargaFicticiaReserva()
        {
            Reserva nuevaReserva = new Reserva();
            nuevaReserva.idReserva = 1;
            nuevaReserva.usuarioReserva = "comensal@bodegon.com";
            nuevaReserva.eventoReserva = "Italia Nuestra";
            nuevaReserva.recetaReserva = "Lassagna";
            nuevaReserva.comensalesReserva = 4;
            ListaReserva.Add(nuevaReserva);


        }
    }
}
