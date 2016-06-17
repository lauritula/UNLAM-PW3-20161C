using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;

namespace Repositorio
{

   
    public class CocineroRepositorio
    {
        public ComentariosRepositorio comenRepo = new ComentariosRepositorio();

        PW3_TP_20161CEntities Contexto;
        
        public CocineroRepositorio()
        {
            Contexto = new PW3_TP_20161CEntities();
        }

//////////EVENTOS
        //creacion de la lista de eventos
        public static List<Eventos> ListaEventos = new List<Eventos>();

        //método para añadir nuevo evento a la lista
        public void CrearEvento(Eventos nuevoEvento) 
        {
            nuevoEvento.Estado = 1; // estado 1 = Programado, 2 = en curso, 3 = finalizado, 4 = Cancelado
  //          ListaEventos.Add(nuevoEvento);
            Contexto.Eventos.Add(nuevoEvento);
            Contexto.SaveChanges();
        }

        //método para obtener un evento por su nombre
        public Eventos ObtenerPorNombre(string nombreEvento)
        {
                var ev = (from e in Contexto.Eventos
                                where e.Nombre == nombreEvento
                                select e).FirstOrDefault();
                return ev;
        }
        
        //método para cancelar un evento
        public void cancelarEvento(string nombreEventoACancelar)
        {
            Eventos eventoACancelar = new Eventos();
            eventoACancelar = ObtenerPorNombre(nombreEventoACancelar);
            eventoACancelar.Estado = 4;
        }

        //método para finalizar un evento
        public void finalizarEvento()
        {
            foreach (Eventos ev in Contexto.Eventos)
            {
                if (ev.Fecha == DateTime.Now)
                    ev.Estado = 3 ;
            }            
        }


        //metodo de retorno de eventos por usuario
        public List<Eventos> eventoPorUsuario(int autor)
        {
            List<Eventos> eventoPorUser = new List<Eventos>();
                    var evento = (from e in Contexto.Eventos
                                      where e.IdUsuario == autor
                                      select e).FirstOrDefault();
                    eventoPorUser.Add(evento);

            return eventoPorUser;
        }

        //metodo de retorno de eventos por estado
        public List<Eventos> eventoPorEstado(int estado, int autor)
        {
            List<Eventos> eventoPorStatus = new List<Eventos>();
/*            foreach (Eventos ev in ListaEventos)
            {
                if (ev.Estado != estado & ev.IdUsuario == autor)
                    eventoPorStatus.Add(ev);
            }
*/
            var evento = (from e in Contexto.Eventos
                          where e.IdUsuario == autor 
                          && e.Estado != estado
                          select e).FirstOrDefault();
            eventoPorStatus.Add(evento);
            return eventoPorStatus;
        }

        //Eventos disponibles para reservar
        public List<Eventos> eventoDisponibles(int estado)
        {
            List<Eventos> eventoAReservar = new List<Eventos>();
            foreach (Eventos ev in ListaEventos )
            {
                if (ev.Estado != estado & ev.CantidadComensales > ev.)
                    eventoAReservar.Add(ev);
                
            }
            return eventoAReservar;
        }

        /*
        public Eventos ObtenerRecientes(int id)
        {

        }

        public Eventos ObtenerPuntuacion(int id)
        {
                decimal puntuacionTotal;

                decimal puntuacionevento = ;

            return;
        }
        */


//////////RECETAS

        //creacion de la lista de recetas
        public static List<Recetas> ListaRecetas = new List<Recetas>();

        //método para añadir nueva receta a la lista
        public void CrearReceta(Recetas nuevaReceta)
        {
            ListaRecetas.Add(nuevaReceta);
        }

        //metodo de retorno de recetas por usuario
        public List<Recetas> recetasPorUsuario(int autor) 
        { 
            List<Recetas> recetasPorUser = new List<Recetas>();
            foreach (Recetas re in ListaRecetas)
            {
                if (re.IdUsuario == autor)
                    recetasPorUser.Add(re);
            }
            return recetasPorUser; 
        }


    }
}