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

        //metodo de retorno de eventos por usuario
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

        //metodo de retorno de eventos por estado
        public List<Reserva> reservaFinalizados(string estado, string autor)
        {
            List<Reserva> reservaPorStatus = new List<Reserva>();
            foreach (Reserva re in ListaReserva)
            {
                if (re.estadoReserva == estado & re.usuarioReserva == autor)
                    reservaPorStatus.Add(re);
            }
            return reservaPorStatus;
        }


        public void cargaFicticiaReserva()
        {
            Reserva nuevaReserva = new Reserva();
            nuevaReserva.idReserva = 1;
            nuevaReserva.usuarioReserva = "comensal@bodegon.com";
            nuevaReserva.eventoReserva = "Italia Nuestra";
            nuevaReserva.recetaReserva = "Lassagna";
            nuevaReserva.comensalesReserva = 4;
            nuevaReserva.estadoReserva = "Finalizado";
            ListaReserva.Add(nuevaReserva);

            Reserva nuevaReserva2 = new Reserva();
            nuevaReserva2.idReserva = 2;
            nuevaReserva2.usuarioReserva = "comensal@bodegon.com";
            nuevaReserva2.eventoReserva = "Italia Nuestra";
            nuevaReserva2.recetaReserva = "Lassagna";
            nuevaReserva2.comensalesReserva = 4;
            nuevaReserva2.estadoReserva = "En curso";
            ListaReserva.Add(nuevaReserva2);
        }

    }
}
