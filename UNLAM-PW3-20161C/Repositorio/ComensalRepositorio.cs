using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Entidades;

namespace Repositorio
{
    public class ComensalRepositorio
    {
        PW3_TP_20161CEntities Contexto;
        
        public ComensalRepositorio()
        {
            Contexto = new PW3_TP_20161CEntities();
        }


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


        public void cargaFicticiaReserva( )
        {
            Reserva nuevaReserva = new Reserva();            
            nuevaReserva.idReserva = 1;
            nuevaReserva.usuarioReserva = "comensal@bodegon.com";
            nuevaReserva.eventoReserva = "Italia Mia";
            nuevaReserva.recetaReserva = "Lassagna";
            nuevaReserva.comensalesReserva = 4;
            nuevaReserva.estadoReserva = "Finalizado";
            ListaReserva.Add(nuevaReserva);

            Reserva nuevaReserva2 = new Reserva();
            nuevaReserva2.idReserva = 2;
            nuevaReserva2.usuarioReserva = "comensal@bodegon.com";
            nuevaReserva2.eventoReserva = "Gourmet";
            nuevaReserva2.recetaReserva = "Tacos";
            nuevaReserva2.comensalesReserva = 4;
            nuevaReserva2.estadoReserva = "Finalizado";
            ListaReserva.Add(nuevaReserva2);

            Reserva nuevaReserva3 = new Reserva();
            nuevaReserva3.idReserva = 3;
            nuevaReserva3.usuarioReserva = "comensal@bodegon.com";
            nuevaReserva3.eventoReserva = "China Meal";
            nuevaReserva3.recetaReserva = "Wok de Pollo";
            nuevaReserva3.comensalesReserva = 4;
            nuevaReserva3.estadoReserva = "En curso";
            ListaReserva.Add(nuevaReserva3);

            Reserva nuevaReserva4 = new Reserva();
            nuevaReserva4.idReserva = 4;
            nuevaReserva4.usuarioReserva = "comensal@bodegon.com";
            nuevaReserva4.eventoReserva = "Todo Postre";
            nuevaReserva4.recetaReserva = "Ganage";
            nuevaReserva4.comensalesReserva = 4;
            nuevaReserva4.estadoReserva = "Finalizado";
            ListaReserva.Add(nuevaReserva4);
            
        }

    }
}
