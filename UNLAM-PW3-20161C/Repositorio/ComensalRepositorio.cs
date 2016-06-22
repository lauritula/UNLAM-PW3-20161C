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

        public void CrearReserva(Reservas nuevaReserva)
        {
            Contexto.Reservas.Add(nuevaReserva);
                Contexto.SaveChanges();
        }

        //metodo de retorno de eventos por usuario
        public IQueryable<Eventos> reservaPorUsuario(int autor)
        {
            var evento = from e in Contexto.Eventos
                         join r in Contexto.Reservas
                                on e.IdEvento equals r.IdEvento
                         where r.IdUsuario == autor
                         && e.Estado == 1
                         || e.Estado == 2
                         select e;
            return evento;
        }

        //metodo de retorno de eventos por estado
        public IQueryable<Eventos> reservaFinalizados(int autor)
        {
           var evento = from e in Contexto.Eventos
                         join r in Contexto.Reservas
                                on e.IdEvento equals r.IdEvento
                         where r.IdUsuario == autor
                         && e.Estado != 1
                         && e.Estado != 2
                         select e;
            return evento;
        }
        
            
        

    }
}
