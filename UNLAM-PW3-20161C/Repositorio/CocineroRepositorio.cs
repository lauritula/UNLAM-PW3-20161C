using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;
using System.Data.Entity.Validation;


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
            Contexto.Eventos.Add(nuevoEvento);
            try
            {
                Contexto.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                
                throw;
            }
            
        }

        public void EventoReceta(int idEve )
        {
            
        }

        //método para obtener un evento por su nombre
        public IQueryable<Eventos> ObtenerPorNombre(string nombreEvento)
        {
                var evento = from c in Contexto.Comentarios
                             join e in Contexto.Eventos
                                    on c.IdEvento equals e.IdEvento
                             where e.Nombre == nombreEvento
                             select e;
                return evento;
        }

        public Eventos ObtenerPorId(int id)
        {
            var evento = (from e in Contexto.Eventos
                          where e.IdEvento == id
                          select e).FirstOrDefault();

            return evento;
        }

        public IQueryable<Eventos> ObtenerEventoId(int id)
        {
            var evento = from e in Contexto.Eventos
                         where e.IdEvento == id
                         select e;

            return evento;
        }

        //método para cancelar un evento
        public void cancelarEvento(int id)
        {
            Eventos eventoACancelar = new Eventos();
            eventoACancelar = ObtenerPorId(id);
            eventoACancelar.Estado = 4;
            Contexto.SaveChanges();
        }

        //método para finalizar un evento
        public void finalizarEvento()
        {
            foreach (Eventos ev in Contexto.Eventos)
            {
                if (ev.Fecha <= DateTime.Now)
                    ev.Estado = 3 ;
            }
            Contexto.SaveChanges();
        }


        //metodo de retorno de eventos por usuario
        public IQueryable<Eventos> eventoPorUsuario(int autor)
        {
                    var evento = from e in Contexto.Eventos
                                      where e.IdUsuario == autor
                                      select e;
            return evento;
        }

        //metodo de retorno de eventos por estado
        public IQueryable<Eventos> eventoPorEstado(int estado, int autor)
        {
/*             List<Eventos> eventoPorStatus = new List<Eventos>();
           foreach (Eventos ev in ListaEventos)
            {
                if (ev.Estado != estado & ev.IdUsuario == autor)
                    eventoPorStatus.Add(ev);
            }
*/
            var evento = from e in Contexto.Eventos
                         where e.IdUsuario == autor
                         && e.Estado == 1
                         select e;
            return evento;
        }

        public int eventoPorEstadoI(int estado, int autor)
        {
            int cantidad = 0;

            foreach (var item in Contexto.Eventos)
            {
                var evento = (from e in Contexto.Eventos
                              where e.IdUsuario == autor
                              && e.Estado == 1
                              || e.Estado == 2
                              select e).FirstOrDefault();
                cantidad = cantidad + 1;
            }
            return cantidad;
        }

        //Eventos disponibles para reservar
        public IQueryable<Eventos> eventoDisponibles()
        {
            var evento = from e in Contexto.Eventos
                         where e.Estado == 1
                         select e;
            return evento;
        }


        public Eventos ObtenerRecientes(int id)
        {  
                        var evento = (from e in Contexto.Eventos
                                      where e.Fecha < DateTime.Today
                                      && e.IdEvento == id
                                          //            && e.Fecha > DateTime.Today
                                      && e.Estado == 3
                                      select e).FirstOrDefault();
                        return evento;
        }

        public decimal ObtenerPuntuacion(int id)
        {
            decimal puntuacionEvento = 0;
            byte i = 0;

            foreach (var item in Contexto.Comentarios)
            {
                byte puntua = (from e in Contexto.Comentarios
                              where e.IdEvento == id
                              select e.Puntuacion).FirstOrDefault();
                puntuacionEvento = puntuacionEvento + puntua;
                i++;
            }

            puntuacionEvento = puntuacionEvento / i;

            return puntuacionEvento;
        }



//////////RECETAS

        //creacion de la lista de recetas
  //      public static List<Recetas> ListaRecetas = new List<Recetas>();

        //método para añadir nueva receta a la lista
        public void CrearReceta(Recetas nuevaReceta)
        {
            Contexto.Recetas.Add(nuevaReceta);
            Contexto.SaveChanges();
        }

        //metodo de retorno de recetas por usuario
        public IQueryable<Recetas> recetasPorUsuario(int autor) 
        { 
            var receta = from e in Contexto.Recetas
                              where e.IdUsuario == autor
                              select e;
            
            return receta; 
        }

        public Recetas recetasPorId(int id)
        {
                var receta = (from e in Contexto.Recetas
                         where e.IdReceta == id
                         select e).FirstOrDefault();
                return receta;
       }

        public int cantRecetas(int id)
        {
            int cantidad = 0;

            foreach (var item in Contexto.Recetas)
            {
               var receta = (from e in Contexto.Recetas
                          where e.IdReceta == id
                          select e).FirstOrDefault();
                cantidad = cantidad + 1;
            }
            return cantidad;
        }

        public IEnumerable<Recetas> recetasPorEvento(int id)
        {
         
            var receta = from r in Contexto.Recetas
                   /*      join e in Contexto.Eventos
                                on r.Eventos equals e.Recetas*/ 
                         where !Contexto.Eventos.Select( e => e.IdEvento).Contains(r.IdReceta)
                         select r;
            return receta;
        }

        public List<Recetas> obtenerRecetas()
        {
            List<Recetas> nueva = new List<Recetas>();
            foreach (Recetas item in Contexto.Recetas)
            {
                var receta = (from e in Contexto.Recetas
                             where e.IdReceta == item.IdReceta
                            select e).FirstOrDefault();
                nueva.Add(receta);
            }

            return nueva;
        }

    }
}